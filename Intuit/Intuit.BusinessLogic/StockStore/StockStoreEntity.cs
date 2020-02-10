using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockStore
{

    internal class StockEntityStore : IStockEntityStore
    {
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Save(Stock stock)
        {
            //Save to Db ToDO
        }

        public void Update(Stock stock)
        {
            throw new NotImplementedException();
        }
    }

    public class StockStoreFactory
    {
        public static IStockEntityStore GetStockStore()
        {
            return new StockEntityStore();
        }
    }
}
