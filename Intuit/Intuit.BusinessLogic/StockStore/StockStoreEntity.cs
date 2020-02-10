using Intuit.BusinessLogic.Stocks;
using Intuit.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockStore
{
    /// <summary>
    /// Class to store Stock data to DB
    /// </summary>
    internal class StockEntityStore : IStockEntityStore
    {
        IStockRepository<StockEntity> repo;

        public StockEntityStore(IStockRepository<StockEntity> stockrepo)
        {
            repo = stockrepo;

        }

        public void Delete(int Id)
        {
            
        }

        public void Save(Stock stock)
        {
            //Save to Db ToDO
        }

        public void Update(Stock stock)
        {
           
        }
    }

    /// <summary>
    /// Class to store Stock list data to DB
    /// </summary>
    internal class StockListStore : IStockListStore
    {
        IStockRepository<StockEntity> repo;
        public StockListStore(IStockRepository<StockEntity> stockrepo)
        {
            repo = stockrepo;
            
        }

        public void Save(List<Stock>stock)
        {
            //Save to Db ToDO

            foreach (var item in stock)
            {
                //repo.Delete(item.ID);
                 // repo.Insert();
            }

            repo.Save();
        }

      
    }

    /// <summary>
    /// /Factory class to generate different stock repositories
    /// </summary>
    public class StockStoreFactory
    {
        public static IStockEntityStore GetStockStore()
        {
            return new StockEntityStore(new StockRepository<StockEntity>(UnitOfWork.GetDbContext()));
        }

        public static IStockListStore GetStockListStore()
        {

            return new StockListStore(new StockRepository<StockEntity>(UnitOfWork.GetDbContext()));
        }
    }
}
