using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.Search
{
   public class StockSearchFactory
    {
        static IStockSearch srch;
        static readonly object b = new object();

        public static IStockSearch GetSearchEntity()
        {
            lock (b)
            {
                if(srch==null)
                {
                    srch = new ApiStockSearch();
                }

            }

            return srch;
        }
    }
}
