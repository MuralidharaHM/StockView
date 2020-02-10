using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intuit.BusinessLogic.StockConfigurations;
using Intuit.BusinessLogic.Stocks;

namespace Intuit.BusinessLogic.StockContainers
{
    public interface IStockContainerEvents
    {
         event Action OnAdd;
         event Action OnRemove;
    }

    public interface IDefinedStockContainer: IStockContainer, IStockConfiguration, IStockContainerEvents
    {

    }
    internal class DefinedStockContainer : IDefinedStockContainer
    {
       
        public List<IStock> Stocks { get; private set; }

        private DefinedStockContainer()
        {
            Stocks = new List<IStock>();
        }

        public event Action OnAdd;
        public event Action OnRemove;

        public void Add(IStock stock)
        {
            if (Stocks.Where(a => a.ID == stock.ID).Count() == 0)
            {
                Stocks.Add(stock);
                OnAdd?.Invoke();
            }
        }

        public void Remove(string Id)
        {
           var stck= Stocks.Where(a => a.ID == Id).FirstOrDefault();
            if (stck != null)
            {
                Stocks.Remove(stck);
                OnRemove?.Invoke();
            }
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
