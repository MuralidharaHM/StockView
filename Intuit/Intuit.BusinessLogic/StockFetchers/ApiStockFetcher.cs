using Intuit.BusinessLogic.Stocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockFetchers
{
    public interface IApiStockDataFetch : IStockDataFetch<Stock>, IHistoricalDataFetch<IStockIdentity, HistoricalStockData>, IDisposable
    {

    }

    internal class FinHistoricalList
    {

        public List<FinList> historicalStockList { get; set; }
    }
    internal class FinList
    {
        public string symbol { get; set; }

        public List<FinModelData> historical { get; set; }
    }

    internal class FinStock
    {
        public string symbol { get; set; }
        public decimal price { get; set; }
    }


    internal class FinStockList
    {
        public List<FinStock> companiesPriceList { get; set; }
    }
    internal class FinModelData
    {
        public DateTime date { get; set; }
        public decimal open { get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
        public decimal close { get; set; }
        public decimal change { get; set; }
        public decimal changePercent { get; set; }

    }
    internal class ApiStockDataFetch : IApiStockDataFetch
    {
        //TODO:Should be read from Configuration 
        readonly string apiCurrentUrl = "https://financialmodelingprep.com/api/v3/stock/real-time-price/";
        readonly string apiHistoricalUrl = "https://financialmodelingprep.com/api/v3/historical-price-full/";
        HttpClient client;
        public ApiStockDataFetch()
        {
           
        }


        public void Dispose()
        {
            //client.Dispose();
        }

        public Stock GetCurrentStockData(string StockName)
        {
            try
            {
                return GetCurrentStockDataAsync(StockName).Result;
            }
            catch (AggregateException ex)
            {
                //logging
            }
            
            return null;
        }

        public async Task<Stock> GetCurrentStockDataAsync(string StockName)
        {
            using (client = new HttpClient())
            {
                var resp = await client.GetAsync(apiCurrentUrl + StockName);
                var jsonString = await resp.Content.ReadAsStringAsync();
                var res = JsonConvert.DeserializeObject<FinStock>(jsonString);

                return Convert(res);
            }
        }

        public List<Stock> GetCurrentStockList(List<IStockIdentity> StockNames)
        {
            try
            {
                return GetCurrentStockListAsync(StockNames).Result;
            }
            catch (AggregateException ex)
            {
                //logging
            }
            return null;
        }

        public async Task<List<Stock>> GetCurrentStockListAsync(List<IStockIdentity> StockNames)
        {
            using (client = new HttpClient())
            {
                var resp = await client.GetAsync(apiCurrentUrl + string.Join(",", StockNames.Select(a => a.ID)));
                var jsonString = await resp.Content.ReadAsStringAsync();
                var res = JsonConvert.DeserializeObject<FinStockList>(jsonString);

                return Convert(res).ToList();
            }
        }


        public List<HistoricalStockData> GetStockData(List<IStockIdentity> stocks, int days)
        {
            try
            {
                return GetStockDataAsync(stocks, days).Result;
            }
            catch (AggregateException ex)
            {
                //logging
            }
            return null;
        }

        public async Task<List<HistoricalStockData>> GetStockDataAsync(List<IStockIdentity> stocks, int days)
        {
            List<HistoricalStockData> data = new List<HistoricalStockData>();
            using (client = new HttpClient())
            {
                var tasks = stocks.Select(async (stock) =>
            {

                var resp = await client.GetAsync(apiHistoricalUrl + stock.ID + "?timeseries=" + days.ToString());
                var jsonString = await resp.Content.ReadAsStringAsync();
                var res = JsonConvert.DeserializeObject<FinList>(jsonString);

                if (res.symbol != null)
                {
                    data.Add(Convert(res));
                }
            });

                await Task.WhenAll(tasks);

                return data;
            }
        }


        private HistoricalStockData Convert(FinList list)
        {
                return new HistoricalStockData()
                {
                    Name = list.symbol,
                    ID = list.symbol,
                    StockDate = list.historical[0].date,
                    High = list.historical[0].high,
                    Low = list.historical[0].low,
                    Price = list.historical[0].close
                };


        }

        /// <summary>
        ///  this api feteches realtime data feom US stock exchange but since when showing the demo the stock market would be closed and prices will be contant 
        ///  doing work arnd by adding random number to generate frequent chnaging price
        /// </summary>
        Random n = new Random();
        private Stock Convert(FinStock stock)
        {
            return new Stock()
            {
                Name = stock.symbol,
                ID = stock.symbol,
                Price = stock.price +n.Next(-2, 10)
            };

        }

        private IEnumerable<Stock> Convert(FinStockList stocks)
        {

            foreach (var stock in stocks.companiesPriceList)
            {
               
                yield return new Stock()
                {
                    Name = stock.symbol,
                    ID = stock.symbol,
                    Price = stock.price +n.Next(-2,10)
                };


            }

        }

    }
}
