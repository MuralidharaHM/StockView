using System;
using Intuit.BusinessLogic.StockContainers;
using Intuit.BusinessLogic.Stocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intuit.BusinessLogic.UnitTests
{
    [TestClass]
    public class DefinedStockTest
    {
        [TestMethod]
        public void TestDefinedStockAdd()
        {
            IDefinedStockContainer definedStockContainer = StockContainerCreator.GetDefinedStockContainer();
            definedStockContainer.Add(new Stock() { Name = "AAPL", ID = "AAPL" });
            definedStockContainer.Add(new Stock() { Name = "BIOX", ID = "BIOX" });
            definedStockContainer.Add(new Stock() { Name = "GHM", ID = "GHM" });
            definedStockContainer.Add(new Stock() { Name = "PALL", ID = "PALL" });
            definedStockContainer.Add(new Stock() { Name = "TRTY", ID = "TRTY" });

            Assert.IsTrue(5==definedStockContainer.Stocks.Count);
        }
        [TestMethod]
        public void TestDefinedStockRemove()
        {
            IDefinedStockContainer definedStockContainer = StockContainerCreator.GetDefinedStockContainer();
            definedStockContainer.Add(new Stock() { Name = "AAPL", ID = "AAPL" });
            definedStockContainer.Add(new Stock() { Name = "BIOX", ID = "BIOX" });
            definedStockContainer.Add(new Stock() { Name = "GHM", ID = "GHM" });
            definedStockContainer.Add(new Stock() { Name = "PALL", ID = "PALL" });
            definedStockContainer.Add(new Stock() { Name = "TRTY", ID = "TRTY" });
            definedStockContainer.Remove(definedStockContainer.Stocks[0]);
            Assert.IsTrue(4 == definedStockContainer.Stocks.Count);
        }
    }
}
