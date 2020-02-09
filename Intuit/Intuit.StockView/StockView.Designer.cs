namespace Intuit.StockView
{
    partial class StockView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockView));
            this.dtGrdStockView = new System.Windows.Forms.DataGridView();
            this.lblHeaderMyStock = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdStockView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdStockView
            // 
            this.dtGrdStockView.AllowUserToAddRows = false;
            this.dtGrdStockView.AllowUserToDeleteRows = false;
            this.dtGrdStockView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGrdStockView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrdStockView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGrdStockView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdStockView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrdStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdStockView.GridColor = System.Drawing.SystemColors.Control;
            this.dtGrdStockView.Location = new System.Drawing.Point(86, 89);
            this.dtGrdStockView.Name = "dtGrdStockView";
            this.dtGrdStockView.ReadOnly = true;
            this.dtGrdStockView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrdStockView.RowHeadersWidth = 50;
            this.dtGrdStockView.ShowCellErrors = false;
            this.dtGrdStockView.ShowCellToolTips = false;
            this.dtGrdStockView.ShowEditingIcon = false;
            this.dtGrdStockView.Size = new System.Drawing.Size(751, 337);
            this.dtGrdStockView.TabIndex = 0;
            this.dtGrdStockView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtGrdStockView_CellFormatting);
            // 
            // lblHeaderMyStock
            // 
            this.lblHeaderMyStock.AutoSize = true;
            this.lblHeaderMyStock.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderMyStock.Location = new System.Drawing.Point(316, 27);
            this.lblHeaderMyStock.Name = "lblHeaderMyStock";
            this.lblHeaderMyStock.Size = new System.Drawing.Size(192, 28);
            this.lblHeaderMyStock.TabIndex = 1;
            this.lblHeaderMyStock.Text = "My Defined Stocks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Define Stocks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Minimize to Tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHeaderMyStock);
            this.Controls.Add(this.dtGrdStockView);
            this.Name = "StockView";
            this.Text = "Stock View";
            this.Resize += new System.EventHandler(this.StockView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdStockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdStockView;
        private System.Windows.Forms.Label lblHeaderMyStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

