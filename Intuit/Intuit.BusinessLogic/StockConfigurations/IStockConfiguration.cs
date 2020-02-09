using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockConfigurations
{
    public interface IStockConfigurationAdd
    {
        void Add(IStock stock);

    }
    public interface IStockConfigurationUpdate
    {
        void Update(IStock stock);

    }

    public interface IStockConfigurationDelete
    {
        void Remove(IStock stock);

    }

    public interface IStockConfiguration : IStockConfigurationAdd, IStockConfigurationDelete
    {
    }
}
