namespace HostelApp.Screens
{
    partial class AdminPage
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
            this.BtnCstmrTbl = new System.Windows.Forms.Button();
            this.BtnRomTbl = new System.Windows.Forms.Button();
            this.BtnNewAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCstmrTbl
            // 
            this.BtnCstmrTbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCstmrTbl.Location = new System.Drawing.Point(401, 250);
            this.BtnCstmrTbl.Name = "BtnCstmrTbl";
            this.BtnCstmrTbl.Size = new System.Drawing.Size(140, 94);
            this.BtnCstmrTbl.TabIndex = 0;
            this.BtnCstmrTbl.Text = "CUSTOMER DATABASE";
            this.BtnCstmrTbl.UseVisualStyleBackColor = true;
            this.BtnCstmrTbl.Click += new System.EventHandler(this.BtnCstmrTbl_Click);
            // 
            // BtnRomTbl
            // 
            this.BtnRomTbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRomTbl.Location = new System.Drawing.Point(631, 250);
            this.BtnRomTbl.Name = "BtnRomTbl";
            this.BtnRomTbl.Size = new System.Drawing.Size(140, 94);
            this.BtnRomTbl.TabIndex = 1;
            this.BtnRomTbl.Text = "ROOM DATABASE";
            this.BtnRomTbl.UseVisualStyleBackColor = true;
            // 
            // BtnNewAdm
            // 
            this.BtnNewAdm.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNewAdm.Location = new System.Drawing.Point(856, 250);
            this.BtnNewAdm.Name = "BtnNewAdm";
            this.BtnNewAdm.Size = new System.Drawing.Size(140, 94);
            this.BtnNewAdm.TabIndex = 2;
            this.BtnNewAdm.Text = "ADD NEW ADMIN";
            this.BtnNewAdm.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 706);
            this.Controls.Add(this.BtnNewAdm);
            this.Controls.Add(this.BtnRomTbl);
            this.Controls.Add(this.BtnCstmrTbl);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCstmrTbl;
        private System.Windows.Forms.Button BtnRomTbl;
        private System.Windows.Forms.Button BtnNewAdm;
    }
}