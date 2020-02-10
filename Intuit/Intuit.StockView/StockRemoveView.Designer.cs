namespace Intuit.StockView
{
    partial class StockRemoveView
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
            this.dtGrdDefined = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDefined)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdDefined
            // 
            this.dtGrdDefined.AllowUserToAddRows = false;
            this.dtGrdDefined.AllowUserToDeleteRows = false;
            this.dtGrdDefined.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGrdDefined.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrdDefined.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdDefined.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtGrdDefined.GridColor = System.Drawing.SystemColors.Control;
            this.dtGrdDefined.Location = new System.Drawing.Point(71, 71);
            this.dtGrdDefined.Name = "dtGrdDefined";
            this.dtGrdDefined.RowHeadersVisible = false;
            this.dtGrdDefined.Size = new System.Drawing.Size(329, 176);
            this.dtGrdDefined.TabIndex = 6;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Select.Width = 20;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(325, 274);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select stocks to remove";
            // 
            // StockRemoveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dtGrdDefined);
            this.MaximizeBox = false;
            this.Name = "StockRemoveView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Stocks";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDefined)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdDefined;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
    }
}