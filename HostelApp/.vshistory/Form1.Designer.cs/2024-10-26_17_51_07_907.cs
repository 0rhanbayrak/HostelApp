namespace HostelApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.textBoxIdNo = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.CheckInDate = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.CustomerInfos = new System.Windows.Forms.GroupBox();
            this.RoomInfo = new System.Windows.Forms.GroupBox();
            this.Btn101 = new System.Windows.Forms.Button();
            this.Btn102 = new System.Windows.Forms.Button();
            this.Btn202 = new System.Windows.Forms.Button();
            this.Btn301 = new System.Windows.Forms.Button();
            this.Btn303 = new System.Windows.Forms.Button();
            this.BtEmpty = new System.Windows.Forms.Button();
            this.BtnFull = new System.Windows.Forms.Button();
            this.Btn201 = new System.Windows.Forms.Button();
            this.Btn302 = new System.Windows.Forms.Button();
            this.Btn203 = new System.Windows.Forms.Button();
            this.Btn103 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CustomerInfos.SuspendLayout();
            this.RoomInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Room No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Check-in Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Check-out Date :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(162, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 27);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Location = new System.Drawing.Point(162, 225);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(214, 27);
            this.textBoxRoomNo.TabIndex = 9;
            // 
            // textBoxIdNo
            // 
            this.textBoxIdNo.Location = new System.Drawing.Point(162, 191);
            this.textBoxIdNo.Name = "textBoxIdNo";
            this.textBoxIdNo.Size = new System.Drawing.Size(214, 27);
            this.textBoxIdNo.TabIndex = 10;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(162, 159);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(214, 27);
            this.textBoxMail.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(162, 89);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(214, 27);
            this.textBoxSurname.TabIndex = 12;
            // 
            // CheckInDate
            // 
            this.CheckInDate.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckInDate.Location = new System.Drawing.Point(162, 262);
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Size = new System.Drawing.Size(214, 25);
            this.CheckInDate.TabIndex = 13;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckOutDate.Location = new System.Drawing.Point(162, 299);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(214, 25);
            this.CheckOutDate.TabIndex = 14;
            // 
            // maskedTextBoxPhoneNo
            // 
            this.maskedTextBoxPhoneNo.Location = new System.Drawing.Point(162, 124);
            this.maskedTextBoxPhoneNo.Mask = "(999) 000-0000";
            this.maskedTextBoxPhoneNo.Name = "maskedTextBoxPhoneNo";
            this.maskedTextBoxPhoneNo.Size = new System.Drawing.Size(214, 27);
            this.maskedTextBoxPhoneNo.TabIndex = 15;
            // 
            // CustomerInfos
            // 
            this.CustomerInfos.Controls.Add(this.label11);
            this.CustomerInfos.Controls.Add(this.label12);
            this.CustomerInfos.Controls.Add(this.button1);
            this.CustomerInfos.Controls.Add(this.CheckInDate);
            this.CustomerInfos.Controls.Add(this.maskedTextBoxPhoneNo);
            this.CustomerInfos.Controls.Add(this.label1);
            this.CustomerInfos.Controls.Add(this.CheckOutDate);
            this.CustomerInfos.Controls.Add(this.label2);
            this.CustomerInfos.Controls.Add(this.label3);
            this.CustomerInfos.Controls.Add(this.textBoxSurname);
            this.CustomerInfos.Controls.Add(this.label4);
            this.CustomerInfos.Controls.Add(this.textBoxMail);
            this.CustomerInfos.Controls.Add(this.label5);
            this.CustomerInfos.Controls.Add(this.textBoxIdNo);
            this.CustomerInfos.Controls.Add(this.label6);
            this.CustomerInfos.Controls.Add(this.textBoxRoomNo);
            this.CustomerInfos.Controls.Add(this.label7);
            this.CustomerInfos.Controls.Add(this.textBoxName);
            this.CustomerInfos.Controls.Add(this.label8);
            this.CustomerInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerInfos.Location = new System.Drawing.Point(116, 34);
            this.CustomerInfos.Name = "CustomerInfos";
            this.CustomerInfos.Size = new System.Drawing.Size(412, 425);
            this.CustomerInfos.TabIndex = 16;
            this.CustomerInfos.TabStop = false;
            this.CustomerInfos.Text = "Customer Information";
            // 
            // RoomInfo
            // 
            this.RoomInfo.Controls.Add(this.Btn103);
            this.RoomInfo.Controls.Add(this.Btn203);
            this.RoomInfo.Controls.Add(this.Btn302);
            this.RoomInfo.Controls.Add(this.Btn201);
            this.RoomInfo.Controls.Add(this.Btn303);
            this.RoomInfo.Controls.Add(this.Btn301);
            this.RoomInfo.Controls.Add(this.Btn202);
            this.RoomInfo.Controls.Add(this.Btn102);
            this.RoomInfo.Controls.Add(this.Btn101);
            this.RoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RoomInfo.Location = new System.Drawing.Point(650, 43);
            this.RoomInfo.Name = "RoomInfo";
            this.RoomInfo.Size = new System.Drawing.Size(412, 416);
            this.RoomInfo.TabIndex = 17;
            this.RoomInfo.TabStop = false;
            this.RoomInfo.Text = "Rooms";
            // 
            // Btn101
            // 
            this.Btn101.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn101.Location = new System.Drawing.Point(32, 86);
            this.Btn101.Name = "Btn101";
            this.Btn101.Size = new System.Drawing.Size(87, 47);
            this.Btn101.TabIndex = 18;
            this.Btn101.Text = "101";
            this.Btn101.UseVisualStyleBackColor = false;
            this.Btn101.Click += new System.EventHandler(this.Btn101_Click);
            // 
            // Btn102
            // 
            this.Btn102.BackColor = System.Drawing.Color.Red;
            this.Btn102.Location = new System.Drawing.Point(172, 86);
            this.Btn102.Name = "Btn102";
            this.Btn102.Size = new System.Drawing.Size(87, 47);
            this.Btn102.TabIndex = 19;
            this.Btn102.Text = "102";
            this.Btn102.UseVisualStyleBackColor = false;
           
            // 
            // Btn202
            // 
            this.Btn202.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn202.Location = new System.Drawing.Point(172, 196);
            this.Btn202.Name = "Btn202";
            this.Btn202.Size = new System.Drawing.Size(87, 47);
            this.Btn202.TabIndex = 22;
            this.Btn202.Text = "202";
            this.Btn202.UseVisualStyleBackColor = false;
            // 
            // Btn301
            // 
            this.Btn301.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn301.Location = new System.Drawing.Point(32, 293);
            this.Btn301.Name = "Btn301";
            this.Btn301.Size = new System.Drawing.Size(87, 47);
            this.Btn301.TabIndex = 24;
            this.Btn301.Text = "301";
            this.Btn301.UseVisualStyleBackColor = false;
            // 
            // Btn303
            // 
            this.Btn303.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn303.Location = new System.Drawing.Point(304, 293);
            this.Btn303.Name = "Btn303";
            this.Btn303.Size = new System.Drawing.Size(87, 47);
            this.Btn303.TabIndex = 26;
            this.Btn303.Text = "303";
            this.Btn303.UseVisualStyleBackColor = false;
            // 
            // BtEmpty
            // 
            this.BtEmpty.BackColor = System.Drawing.Color.Chartreuse;
            this.BtEmpty.Location = new System.Drawing.Point(747, 465);
            this.BtEmpty.Name = "BtEmpty";
            this.BtEmpty.Size = new System.Drawing.Size(87, 47);
            this.BtEmpty.TabIndex = 20;
            this.BtEmpty.UseVisualStyleBackColor = false;
            // 
            // BtnFull
            // 
            this.BtnFull.BackColor = System.Drawing.Color.Red;
            this.BtnFull.Location = new System.Drawing.Point(884, 465);
            this.BtnFull.Name = "BtnFull";
            this.BtnFull.Size = new System.Drawing.Size(87, 47);
            this.BtnFull.TabIndex = 21;
            this.BtnFull.UseVisualStyleBackColor = false;
            // 
            // Btn201
            // 
            this.Btn201.BackColor = System.Drawing.Color.Red;
            this.Btn201.Location = new System.Drawing.Point(32, 196);
            this.Btn201.Name = "Btn201";
            this.Btn201.Size = new System.Drawing.Size(87, 47);
            this.Btn201.TabIndex = 22;
            this.Btn201.Text = "201";
            this.Btn201.UseVisualStyleBackColor = false;
            // 
            // Btn302
            // 
            this.Btn302.BackColor = System.Drawing.Color.Red;
            this.Btn302.Location = new System.Drawing.Point(172, 293);
            this.Btn302.Name = "Btn302";
            this.Btn302.Size = new System.Drawing.Size(87, 47);
            this.Btn302.TabIndex = 22;
            this.Btn302.Text = "302";
            this.Btn302.UseVisualStyleBackColor = false;
            // 
            // Btn203
            // 
            this.Btn203.BackColor = System.Drawing.Color.Red;
            this.Btn203.Location = new System.Drawing.Point(304, 196);
            this.Btn203.Name = "Btn203";
            this.Btn203.Size = new System.Drawing.Size(87, 47);
            this.Btn203.TabIndex = 22;
            this.Btn203.Text = "203";
            this.Btn203.UseVisualStyleBackColor = false;
            // 
            // Btn103
            // 
            this.Btn103.BackColor = System.Drawing.Color.Red;
            this.Btn103.Location = new System.Drawing.Point(304, 86);
            this.Btn103.Name = "Btn103";
            this.Btn103.Size = new System.Drawing.Size(87, 47);
            this.Btn103.TabIndex = 22;
            this.Btn103.Text = "103";
            this.Btn103.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(880, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Not Available";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(756, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "Available";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(213, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Price :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1307, 565);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnFull);
            this.Controls.Add(this.BtEmpty);
            this.Controls.Add(this.RoomInfo);
            this.Controls.Add(this.CustomerInfos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CustomerInfos.ResumeLayout(false);
            this.CustomerInfos.PerformLayout();
            this.RoomInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.TextBox textBoxIdNo;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.DateTimePicker CheckInDate;
        private System.Windows.Forms.DateTimePicker CheckOutDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNo;
        private System.Windows.Forms.GroupBox CustomerInfos;
        private System.Windows.Forms.GroupBox RoomInfo;
        private System.Windows.Forms.Button Btn303;
        private System.Windows.Forms.Button Btn301;
        private System.Windows.Forms.Button Btn202;
        private System.Windows.Forms.Button Btn102;
        private System.Windows.Forms.Button Btn101;
        private System.Windows.Forms.Button BtEmpty;
        private System.Windows.Forms.Button Btn103;
        private System.Windows.Forms.Button Btn203;
        private System.Windows.Forms.Button Btn302;
        private System.Windows.Forms.Button Btn201;
        private System.Windows.Forms.Button BtnFull;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

