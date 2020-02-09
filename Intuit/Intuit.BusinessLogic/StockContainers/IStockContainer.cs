using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockContainers
{
    public interface IStockContainer
    {
        List<IStock> Stocks { get; }
    }
}
