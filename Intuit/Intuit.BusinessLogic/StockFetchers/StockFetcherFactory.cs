using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockFetchers
{
   public class StockFetcherFactory
    {
        public static IHistoricalDataFetch<IStockIdentity, HistoricalStockData>  GetStockHistorical()
        {
            return new ApiStockDataFetch();
        }
    }
}
