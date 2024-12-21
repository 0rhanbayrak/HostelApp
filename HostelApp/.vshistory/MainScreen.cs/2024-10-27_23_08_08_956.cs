﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelApp
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin frm = new AdminLogin();
            frm.Show();
            this.Hide();
        }

        private void BtnCustRgst_Click(object sender, EventArgs e)
        {
            CustomerRegister frm = new CustomerRegister();
            frm.Show();
            this.Hide();
        }

        private void BtnRoomCndts_Click(object sender, EventArgs e)
        {
            RoomConditions frm = new RoomConditions();
            frm.Show();
            this.Hide();
        }
    }
}