using Intuit.BusinessLogic.StockContainers;
using Intuit.BusinessLogic.StockFetchers;
using Intuit.BusinessLogic.Stocks;
using Intuit.BusinessLogic.StockUpdaters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intuit.StockView
{
    public partial class StockView : Form
    {
        IDefinedStockContainer definedStockContainer;
        IStockUpdater stockUpdater;
        IHistoricalDataFetch<IStockIdentity, HistoricalStockData> historicalFetch;
        List<StockViewDisplay> DataSource = new List<StockViewDisplay>();
        public  StockView()
        {
            InitializeComponent();
           

            //define dependencies
            definedStockContainer = StockContainerCreator.GetDefinedStockContainer();
            historicalFetch = StockFetcherFactory.GetStockHistorical();

            definedStockContainer.Add(new Stock() { Name = "AAPL", ID = "AAPL" });
            definedStockContainer.Add(new Stock() { Name = "BIOX", ID = "BIOX" });
            definedStockContainer.Add(new Stock() { Name = "GHM", ID = "GHM" });
            definedStockContainer.Add(new Stock() { Name = "PALL", ID = "PALL" });
            definedStockContainer.Add(new Stock() { Name = "TRTY", ID = "TRTY" });
            setDataSource();
            //fetch saved Stocks
            List<IStockIdentity> identities = definedStockContainer.Stocks.Select(a => a as IStockIdentity).ToList();
           
            stockUpdater = StockUpdaterFactory.Create(identities);
            stockUpdater.Notify += OnNotified;
            stockUpdater.Start();




        }

        public void OnNotified(List<StockInfo> stock)
        {
           
            foreach (var item in stock)
            {
               var d= DataSource.Where(a => a.StockName == item.ID).FirstOrDefault();
                d.Price = item.Price;
                d.Change= item.GetChange();
                d.ChangePercent = (item.PrevDayPrice!=0? ((d.Change/ item.PrevDayPrice) * 100).ToString("0.##"):"0") +"%";
                d.High = item.High;
                d.Low = item.Low;
                
            }


            dtGrdStockView.BeginInvoke((MethodInvoker)delegate () {
                dtGrdStockView.DataSource = DataSource;
            });
        }

       

    private void setDataSource()
        {
            mergeData();
            var source = new BindingSource();
            source.DataSource = DataSource;
            dtGrdStockView.DataSource = source;
        }

        private void mergeData()
        {
            foreach (var item in definedStockContainer.Stocks)
            {
                DataSource.Add(new StockViewDisplay() { StockName = item.Name });
            }
         
        }

        private void dtGrdStockView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==2)
            {
                DataGridView grd = (DataGridView)sender;
                if ((decimal)e.Value< 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }
    }
}
