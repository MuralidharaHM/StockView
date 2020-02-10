namespace Intuit.StockView
{
    partial class DefineStockView
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
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtGrdSearch = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrch
            // 
            this.txtSrch.Location = new System.Drawing.Point(125, 54);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(242, 20);
            this.txtSrch.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(378, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter stock name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtGrdSearch
            // 
            this.dtGrdSearch.AllowUserToAddRows = false;
            this.dtGrdSearch.AllowUserToDeleteRows = false;
            this.dtGrdSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGrdSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtGrdSearch.GridColor = System.Drawing.SystemColors.Control;
            this.dtGrdSearch.Location = new System.Drawing.Point(26, 92);
            this.dtGrdSearch.Name = "dtGrdSearch";
            this.dtGrdSearch.RowHeadersVisible = false;
            this.dtGrdSearch.Size = new System.Drawing.Size(427, 167);
            this.dtGrdSearch.TabIndex = 5;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Select.Width = 20;
            // 
            // DefineStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 361);
            this.Controls.Add(this.dtGrdSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSrch);
            this.MaximizeBox = false;
            this.Name = "DefineStockView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DefineStock";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtGrdSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
    }
}