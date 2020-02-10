using Intuit.BusinessLogic.Search;
using Intuit.BusinessLogic.StockContainers;
using Intuit.BusinessLogic.Stocks;
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
    public partial class DefineStockView : Form
    {
        IStockSearch srch;
        IDefinedStockContainer definedStockContainer;
        public DefineStockView()
        {
            InitializeComponent();
            srch = StockSearchFactory.GetSearchEntity();
            definedStockContainer = StockContainerCreator.GetDefinedStockContainer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtSrch.Text.Trim()!=string.Empty)
            {
                Search(txtSrch.Text.Trim());
            }
        }

        private async void Search(string query)
        {
           var resp= await srch.SearchAsync(txtSrch.Text);

            BindtoDataSource(resp);
            
        }

        private void BindtoDataSource(List<SearchModel> srch)
        {
            List<StockSearchModel> Data = new List<StockSearchModel>();
            
            foreach (var item in srch)
            {
                Data.Add(new StockSearchModel() {StockName=item.name,Currency=item.currency,StockExchange=item.stockExchange,Id=item.symbol });
            }


            dtGrdSearch.BeginInvoke((MethodInvoker)delegate () {
                var source = new BindingSource();
                source.DataSource = Data;
                dtGrdSearch.DataSource = source;
                dtGrdSearch.Columns[1].Visible = false;
            });

           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dtGrdSearch.Rows)
            {
                var sel = dr.Cells[0].Value as bool?;

                if (sel.HasValue && sel.Value)
                {
                    definedStockContainer.Add(new Stock() { ID = (string)dr.Cells[1].Value,Name= (string)dr.Cells[2].Value });
                }
            }
            //add to defined stock
        }
    }
}
