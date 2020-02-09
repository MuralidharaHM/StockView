using Intuit.BusinessLogic.Stocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockFetchers
{
    public  interface IHistoricalDataFetch<T,U>
    {
        List<U> GetStockData(List<T> stocks,int days);
        Task<List<U>> GetStockDataAsync(List<T> stocks, int days);
    }

    public interface IStockDataFetch<T>
    {
        T GetCurrentStockData(string StockName);
        Task<T> GetCurrentStockDataAsync(string StockName);
        List<T> GetCurrentStockList(List<IStockIdentity> StockNames);
        Task<List<T>> GetCurrentStockListAsync(List<IStockIdentity> StockNames);
    }

   
}
