using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.Stocks
{
    public class Stock : IStock
    {
        public string Name { get ; set ; }
        public string ID { get; set; }
        public  decimal Price { get; set; }
    }

  
}
