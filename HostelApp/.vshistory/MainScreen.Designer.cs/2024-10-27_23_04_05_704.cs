namespace HostelApp
{
    partial class MainScreen
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
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnRoomCndts = new System.Windows.Forms.Button();
            this.BtnCustRgst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdmin.Location = new System.Drawing.Point(444, 261);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(150, 116);
            this.BtnAdmin.TabIndex = 0;
            this.BtnAdmin.Text = "Admin Entrance";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnRoomCndts
            // 
            this.BtnRoomCndts.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRoomCndts.Location = new System.Drawing.Point(980, 261);
            this.BtnRoomCndts.Name = "BtnRoomCndts";
            this.BtnRoomCndts.Size = new System.Drawing.Size(150, 116);
            this.BtnRoomCndts.TabIndex = 1;
            this.BtnRoomCndts.Text = "Room Conditions";
            this.BtnRoomCndts.UseVisualStyleBackColor = true;
            this.BtnRoomCndts.Click += new System.EventHandler(this.BtnRoomCndts_Click);
            // 
            // BtnCustRgst
            // 
            this.BtnCustRgst.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCustRgst.Location = new System.Drawing.Point(715, 261);
            this.BtnCustRgst.Name = "BtnCustRgst";
            this.BtnCustRgst.Size = new System.Drawing.Size(150, 116);
            this.BtnCustRgst.TabIndex = 2;
            this.BtnCustRgst.Text = "Customer Register";
            this.BtnCustRgst.UseVisualStyleBackColor = true;
            this.BtnCustRgst.Click += new System.EventHandler(this.BtnCustRgst_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1576, 715);
            this.Controls.Add(this.BtnCustRgst);
            this.Controls.Add(this.BtnRoomCndts);
            this.Controls.Add(this.BtnAdmin);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnRoomCndts;
        private System.Windows.Forms.Button BtnCustRgst;
    }
}