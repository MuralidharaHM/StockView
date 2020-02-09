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
        List<IStockIdentity> Search(string query);
        Task<List<IStockIdentity>> SearchAsync(string query);
    }
    internal class ApiStockSearch : IStockSearch
    {
        readonly string apiSearchUrl = "https://financialmodelingprep.com/api/v3/stock/real-time-price/";
       
        HttpClient client;
        public ApiStockSearch()
        {
            client = new HttpClient();
        }

        public void Dispose()
        {
            client.Dispose();
        }
        public List<IStockIdentity> Search(string query)
        {

            return null;
        }

        public async Task<List<IStockIdentity>> SearchAsync(string query)
        {
            var resp = await client.GetAsync(apiSearchUrl + query);
            var jsonString = await resp.Content.ReadAsStringAsync();
            //var res = JsonConvert.DeserializeObject<FinStock>(jsonString);
            return null;
        }
    }
}
