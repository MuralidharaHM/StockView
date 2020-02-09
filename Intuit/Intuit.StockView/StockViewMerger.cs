using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.StockView
{

    public class StockViewDisplay
    {
        [DisplayName("Stock")]
        public string StockName { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Change")]
        public decimal Change { get; set; }

        [DisplayName("Percent")]
        public string ChangePercent { get; set; }

        [DisplayName("High")]
        public decimal High { get; set; }

        [DisplayName("Low")]
        public decimal Low { get; set; }

    }
    public class StockViewMerger
    {

    }
}
