﻿namespace HostelApp
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
            this.BtnCustRgst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdmin.Location = new System.Drawing.Point(559, 216);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(150, 116);
            this.BtnAdmin.TabIndex = 0;
            this.BtnAdmin.Text = "Admin Login";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnCustRgst
            // 
            this.BtnCustRgst.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCustRgst.Location = new System.Drawing.Point(830, 216);
            this.BtnCustRgst.Name = "BtnCustRgst";
            this.BtnCustRgst.Size = new System.Drawing.Size(150, 116);
            this.BtnCustRgst.TabIndex = 2;
            this.BtnCustRgst.Text = "Customer Register";
            this.BtnCustRgst.UseVisualStyleBackColor = true;
            this.BtnCustRgst.Click += new System.EventHandler(this.BtnCustRgst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1519, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCustRgst);
            this.Controls.Add(this.BtnAdmin);
            this.Name = "MainScreen";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnCustRgst;
        private System.Windows.Forms.Label label1;
    }
}