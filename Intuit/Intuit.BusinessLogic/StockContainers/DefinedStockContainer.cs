using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intuit.BusinessLogic.StockConfigurations;
using Intuit.BusinessLogic.Stocks;

namespace Intuit.BusinessLogic.StockContainers
{
    public interface IDefinedStockContainer: IStockContainer, IStockConfiguration
    {

    }
    internal class DefinedStockContainer : IDefinedStockContainer
    {
        public List<IStock> Stocks { get; private set; }

        private DefinedStockContainer()
        {
            Stocks = new List<IStock>();
        }

        public void Add(IStock stock)
        {
            Stocks.Add(stock);
        }

        public void Remove(IStock stock)
        {
            Stocks.Remove(stock);
        }

        internal class Factory
        {
            public static DefinedStockContainer Create()
            {
                return new DefinedStockContainer();
            }
        }
    }


}
