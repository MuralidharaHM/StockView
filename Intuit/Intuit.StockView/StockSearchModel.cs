using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.StockView
{
   public class StockSearchModel
    {

        public string Id { get; set; }

        [DisplayName("Stock")]
        public string StockName { get; set; }
        [DisplayName("Currency")]
        public string Currency { get; set; }
        [DisplayName("Exchange")]
        public string StockExchange { get; set; }

    }
}
