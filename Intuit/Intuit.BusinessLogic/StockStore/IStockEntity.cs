using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockStore
{
    public  interface IStockEntityStore
    {
        void Save(Stock stock);
        void Update(Stock stock);
        void Delete(int Id);
    }

    /// <summary>
    /// Ideally shouldnt be used but for demo
    /// </summary>
    public interface IStockListStore
    {
        void Save(List<Stock> stock);
      
    }



}
