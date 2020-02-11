using Intuit.BusinessLogic.StockContainers;
using Intuit.BusinessLogic.StockFetchers;
using Intuit.BusinessLogic.Stocks;
using Intuit.BusinessLogic.StockStore;
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
        IStockEntityStore _stockStore;
        public  StockView()
        {
            InitializeComponent();

            //define dependencies
            definedStockContainer = StockContainerCreator.GetDefinedStockContainer();
            definedStockContainer.OnAdd += onStockAdded;
            definedStockContainer.OnRemove += onStockRemoved;

            //fetch saved Stocks
           
            stockUpdater = StockUpdaterFactory.Create();
            stockUpdater.Notify += OnNotified;

            //_stockStore = StockStoreFactory.GetStockStore();
            LoadFrequency();
        }

        private void onStockAdded()
        {
            startUpdater();
        }

        private void onStockRemoved()
        {
            stockUpdater.Stop();
            startUpdater();
        }

        private void startUpdater()
        {
            if (definedStockContainer.Stocks.Count > 0)
                stockUpdater.Start(definedStockContainer.Stocks.Select(a => a as IStockIdentity).ToList());
            else
                dtGrdStockView.DataSource = null;
        }

        private void LoadFrequency()
        {
            List<FrequencyModel> dic = new List<FrequencyModel>();
            dic.Add(new FrequencyModel() {  Key=1000,Name="Seconds"});
            dic.Add(new FrequencyModel() { Key = 3000, Name = "3 Seconds" });
            dic.Add(new FrequencyModel() { Key = 5000, Name = "5 Seconds" });


            cmbFrequency.DataSource = dic;
            cmbFrequency.DisplayMember = "Name";
            cmbFrequency.ValueMember = "Key";
            cmbFrequency.SelectedItem = dic[2];

        }
        public void OnNotified(List<StockInfo> stock)
        {
            List<StockViewDisplay> dataSource = new List<StockViewDisplay>();

            foreach (var item in stock)
            {
                dataSource.Add(new StockViewDisplay()
                {
                     
                    StockName= item.Name,
                    Price = item.Price,
                    Change = item.GetChange(),
                    ChangePercent = (item.PrevDayPrice != 0 ? ((item.GetChange() / item.PrevDayPrice) * 100).ToString("0.##") : "0") + "%",
                    High = item.High,
                    Low = item.Low
                    
                });
                
            }


           dtGrdStockView.BeginInvoke((MethodInvoker)delegate () {
               var source = new BindingSource();
               source.DataSource = dataSource;
               dtGrdStockView.DataSource = source;
           });
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

        private void button1_Click(object sender, EventArgs e)
        {
            DefineStockView dStock = new DefineStockView();
            dStock.ShowDialog();
         
        }

   
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void StockView_Resize(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipTitle = "Stock View app is minimized";
            notifyIcon.BalloonTipText = "Stock live updates will be paused untill maximized";

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                stockUpdater.Stop();
                this.Hide();

            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
                startUpdater();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DefineStockView dfStock = new DefineStockView();
            dfStock.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            StockRemoveView stckRemover = new StockRemoveView();
            stckRemover.ShowDialog();
        }

        private void btnFrequency_Click(object sender, EventArgs e)
        {

        }

        private void cmbFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockUpdater.ChangeFrequency(((FrequencyModel)cmbFrequency.SelectedItem).Key);
        }

        private void btnSaveStocks_Click(object sender, EventArgs e)
        {
            //Save to DB TODO- Business logic ready
            //_stockStore.Save();
        }
    }
}
