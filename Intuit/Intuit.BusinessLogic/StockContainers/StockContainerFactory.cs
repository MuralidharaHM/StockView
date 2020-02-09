using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockContainers
{
    public interface IStockerContainerCreator
    {

    }
    public class StockContainerCreator : IStockerContainerCreator
    {

        static readonly  object _lock = new object();

        static IDefinedStockContainer _stockContainer;
        public static IDefinedStockContainer GetDefinedStockContainer()
        {
            lock (_lock)
            {
                if (_stockContainer == null) _stockContainer=DefinedStockContainer.Factory.Create();
            }
            return _stockContainer;
        }
    }
}
