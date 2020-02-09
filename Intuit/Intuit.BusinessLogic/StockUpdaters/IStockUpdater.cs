using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockUpdaters
{
    public delegate void NotifyUpdate(List<StockInfo> stock);
    public interface IStockUpdater:IDisposable
    {
        void Start();
        void Stop();

        event NotifyUpdate Notify;
    }
}
