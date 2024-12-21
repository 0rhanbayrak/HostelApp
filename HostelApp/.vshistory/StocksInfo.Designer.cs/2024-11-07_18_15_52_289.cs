namespace HostelApp
{
    partial class StocksInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKSINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDBDataSet = new HostelApp.HostelDBDataSet();
            this.sTOCKSINFOTableAdapter = new HostelApp.HostelDBDataSetTableAdapters.STOCKSINFOTableAdapter();
            this.textBoxFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBeverage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSnack = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKSINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodDataGridViewTextBoxColumn,
            this.beverageDataGridViewTextBoxColumn,
            this.snackDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTOCKSINFOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(433, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(565, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // foodDataGridViewTextBoxColumn
            // 
            this.foodDataGridViewTextBoxColumn.DataPropertyName = "Food";
            this.foodDataGridViewTextBoxColumn.HeaderText = "Food";
            this.foodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodDataGridViewTextBoxColumn.Name = "foodDataGridViewTextBoxColumn";
            this.foodDataGridViewTextBoxColumn.Width = 125;
            // 
            // beverageDataGridViewTextBoxColumn
            // 
            this.beverageDataGridViewTextBoxColumn.DataPropertyName = "Beverage";
            this.beverageDataGridViewTextBoxColumn.HeaderText = "Beverage";
            this.beverageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beverageDataGridViewTextBoxColumn.Name = "beverageDataGridViewTextBoxColumn";
            this.beverageDataGridViewTextBoxColumn.Width = 125;
            // 
            // snackDataGridViewTextBoxColumn
            // 
            this.snackDataGridViewTextBoxColumn.DataPropertyName = "Snack";
            this.snackDataGridViewTextBoxColumn.HeaderText = "Snack";
            this.snackDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snackDataGridViewTextBoxColumn.Name = "snackDataGridViewTextBoxColumn";
            this.snackDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTOCKSINFOBindingSource
            // 
            this.sTOCKSINFOBindingSource.DataMember = "STOCKSINFO";
            this.sTOCKSINFOBindingSource.DataSource = this.hostelDBDataSet;
            // 
            // hostelDBDataSet
            // 
            this.hostelDBDataSet.DataSetName = "HostelDBDataSet";
            this.hostelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKSINFOTableAdapter
            // 
            this.sTOCKSINFOTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxFood
            // 
            this.textBoxFood.Location = new System.Drawing.Point(684, 388);
            this.textBoxFood.Name = "textBoxFood";
            this.textBoxFood.Size = new System.Drawing.Size(100, 22);
            this.textBoxFood.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beverage :";
            // 
            // textBoxBeverage
            // 
            this.textBoxBeverage.Location = new System.Drawing.Point(684, 425);
            this.textBoxBeverage.Name = "textBoxBeverage";
            this.textBoxBeverage.Size = new System.Drawing.Size(100, 22);
            this.textBoxBeverage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Snack :";
            // 
            // textBoxSnack
            // 
            this.textBoxSnack.Location = new System.Drawing.Point(684, 464);
            this.textBoxSnack.Name = "textBoxSnack";
            this.textBoxSnack.Size = new System.Drawing.Size(100, 22);
            this.textBoxSnack.TabIndex = 5;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(684, 513);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(88, 51);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // StocksInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 723);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSnack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBeverage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFood);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StocksInfo";
            this.Text = "StocksInfo";
            this.Load += new System.EventHandler(this.StocksInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKSINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HostelDBDataSet hostelDBDataSet;
        private System.Windows.Forms.BindingSource sTOCKSINFOBindingSource;
        private HostelDBDataSetTableAdapters.STOCKSINFOTableAdapter sTOCKSINFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snackDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBeverage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSnack;
        private System.Windows.Forms.Button BtnUpdate;
    }
}