using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.Stocks
{
    public class StockInfo : Stock
    {

        public decimal PrevDayPrice { get; set; }

        public virtual decimal GetChange()
        {
            return PrevDayPrice == 0 ? 0 : Price - PrevDayPrice;
        }


        public decimal High { get; set; }

        public decimal Low { get; set; }
    }
}
