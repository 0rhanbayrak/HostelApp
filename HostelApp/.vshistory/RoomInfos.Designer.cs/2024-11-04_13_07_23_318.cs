namespace HostelApp
{
    partial class RoomInfos
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
            this.ClrRomTbl = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // ClrRomTbl
            // 
            this.ClrRomTbl.Location = new System.Drawing.Point(588, 319);
            this.ClrRomTbl.Name = "ClrRomTbl";
            this.ClrRomTbl.Size = new System.Drawing.Size(106, 62);
            this.ClrRomTbl.TabIndex = 0;
            this.ClrRomTbl.Text = "Clear Room Table";
            this.ClrRomTbl.UseVisualStyleBackColor = true;
            this.ClrRomTbl.Click += new System.EventHandler(this.ClrRomTbl_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(440, 122);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.Size = new System.Drawing.Size(455, 150);
            this.dataGridViewRooms.TabIndex = 1;
            // 
            // RoomInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 720);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.ClrRomTbl);
            this.Name = "RoomInfos";
            this.Text = "Room Infos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClrRomTbl;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
    }
}