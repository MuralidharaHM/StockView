using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.DataAccess
{
    public class StockEntity
    {
        public int Id { get; set; }
        public string StockySymbol { get; set; }
        public string StockyName { get; set; }
        public decimal Price { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public DateTime StockDate { get; set; }
    }
}
