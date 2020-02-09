using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.Stocks
{

    public interface IStockIdentity
    {
        string ID { get; set; }
    }
    public interface IStock: IStockIdentity
    {
        string Name { get; set; }
    
        decimal Price { get; set; }
    }
}
