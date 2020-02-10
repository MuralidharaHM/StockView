using Intuit.BusinessLogic.StockContainers;
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
    public partial class StockRemoveView : Form
    {
        IDefinedStockContainer definedStockContainer;
        public StockRemoveView()
        {
          
            InitializeComponent();
            definedStockContainer = StockContainerCreator.GetDefinedStockContainer();
            LoadStocks();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool isRemoved=false;
            foreach (DataGridViewRow dr in dtGrdDefined.Rows)
            {
                var sel = dr.Cells[0].Value as bool?;

                if (sel.HasValue && sel.Value)
                {
                   
                    definedStockContainer.Remove((string)dr.Cells[1].Value);
                    isRemoved = true;
                }
            }

            if(isRemoved)
            {
                LoadStocks();
            }
        }

        private void LoadStocks()
        {
            List<StockRemoveModel> dataSource = new List<StockRemoveModel>();

            foreach (var item in definedStockContainer.Stocks)
            {
                dataSource.Add(new StockRemoveModel()
                {
                    Symbol = item.ID,
                    Name = item.Name,
                });

            }

            var source = new BindingSource();
            source.DataSource = dataSource;
            dtGrdDefined.DataSource = source;
        }
    }
}
