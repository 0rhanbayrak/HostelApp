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
            this.hostelDBDataSet = new HostelApp.HostelDBDataSet();
            this.sTOCKSINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCKSINFOTableAdapter = new HostelApp.HostelDBDataSetTableAdapters.STOCKSINFOTableAdapter();
            this.foodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKSINFOBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(456, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(604, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // hostelDBDataSet
            // 
            this.hostelDBDataSet.DataSetName = "HostelDBDataSet";
            this.hostelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKSINFOBindingSource
            // 
            this.sTOCKSINFOBindingSource.DataMember = "STOCKSINFO";
            this.sTOCKSINFOBindingSource.DataSource = this.hostelDBDataSet;
            // 
            // sTOCKSINFOTableAdapter
            // 
            this.sTOCKSINFOTableAdapter.ClearBeforeFill = true;
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
            // StocksInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 723);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StocksInfo";
            this.Text = "StocksInfo";
            this.Load += new System.EventHandler(this.StocksInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKSINFOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HostelDBDataSet hostelDBDataSet;
        private System.Windows.Forms.BindingSource sTOCKSINFOBindingSource;
        private HostelDBDataSetTableAdapters.STOCKSINFOTableAdapter sTOCKSINFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snackDataGridViewTextBoxColumn;
    }
}