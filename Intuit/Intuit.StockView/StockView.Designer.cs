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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockView));
            this.dtGrdStockView = new System.Windows.Forms.DataGridView();
            this.lblHeaderMyStock = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dtGrdStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdStockView.GridColor = System.Drawing.SystemColors.Control;
            this.dtGrdStockView.Location = new System.Drawing.Point(202, 116);
            this.dtGrdStockView.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdStockView.MultiSelect = false;
            this.dtGrdStockView.Name = "dtGrdStockView";
            this.dtGrdStockView.ReadOnly = true;
            this.dtGrdStockView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrdStockView.RowHeadersVisible = false;
            this.dtGrdStockView.RowHeadersWidth = 50;
            this.dtGrdStockView.ShowCellErrors = false;
            this.dtGrdStockView.ShowCellToolTips = false;
            this.dtGrdStockView.ShowEditingIcon = false;
            this.dtGrdStockView.Size = new System.Drawing.Size(799, 445);
            this.dtGrdStockView.TabIndex = 0;
            this.dtGrdStockView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtGrdStockView_CellFormatting);
            // 
            // lblHeaderMyStock
            // 
            this.lblHeaderMyStock.AutoSize = true;
            this.lblHeaderMyStock.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderMyStock.Location = new System.Drawing.Point(454, 15);
            this.lblHeaderMyStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderMyStock.Name = "lblHeaderMyStock";
            this.lblHeaderMyStock.Size = new System.Drawing.Size(192, 28);
            this.lblHeaderMyStock.TabIndex = 1;
            this.lblHeaderMyStock.Text = "My Defined Stocks";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Minimize to Tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Define Stocks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(12, 170);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 44);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Stocks";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHeaderMyStock);
            this.Controls.Add(this.dtGrdStockView);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
    }
}

