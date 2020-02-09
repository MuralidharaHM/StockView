using Intuit.BusinessLogic.StockFetchers;
using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockUpdaters
{
    /// <summary>
    /// Create a  component with a strategy
    /// </summary>
    public interface IStockUpdaterCreatorStrategy
    {
        IStockUpdater Create(List<IStockIdentity> stocks);
    }
    /// <summary>
    /// Aysnchronous Background Model with Api Strategy
    /// </summary>
    internal class BackgroundWithApiFetchUpdater: IStockUpdaterCreatorStrategy
    {
       
        public IStockUpdater Create(List<IStockIdentity> stocks)
        {
            return new BackgroundStockUpdater(new ApiStockDataFetch(), stocks, 5000);
        }

        public IStockUpdater Create(List<IStockIdentity> stocks,int frequency)
        {
            return new BackgroundStockUpdater(new ApiStockDataFetch(), stocks, frequency);
        }
    }
}
