using Intuit.BusinessLogic.Stocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.Search
{
    public interface IStockSearch
    {
        List<SearchModel> Search(string query);
        Task<List<SearchModel>> SearchAsync(string query);
    }

     public class SearchModel
    {
       public  string symbol { get; set; }
        public string name { get; set; }
        public string currency { get; set; }
        public string stockExchange { get; set; }
    }
    internal class ApiStockSearch : IStockSearch
    {
        readonly string apiSearchUrl = "https://financialmodelingprep.com/api/v3/search?query={0}&limit=5&exchange=NASDAQ";
       
        HttpClient client;
        public ApiStockSearch()
        {
            client = new HttpClient();
        }

        public void Dispose()
        {
            client.Dispose();
        }
        public List<SearchModel> Search(string query)
        {
            try
            {
                return SearchAsync(query).Result;
            }
            catch(AggregateException ex)
            {
                //logging
            }


            return null;
        }

        public async Task<List<SearchModel>> SearchAsync(string query)
        {
            var resp = await client.GetAsync(string.Format(apiSearchUrl, query)) ;
            var jsonString = await resp.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<SearchModel[]>(jsonString);
            return res.ToList();
        }
    }
}
