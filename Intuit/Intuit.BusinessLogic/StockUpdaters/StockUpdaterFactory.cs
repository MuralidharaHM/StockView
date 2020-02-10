﻿using Intuit.BusinessLogic.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.BusinessLogic.StockUpdaters
{
   public  class StockUpdaterFactory
    {
        public static IStockUpdater Create()
        {
            return new BackgroundWithApiFetchUpdater().Create();
        }
    }
}
