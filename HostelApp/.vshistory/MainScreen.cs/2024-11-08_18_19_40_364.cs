using System;
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
            label1.Text=DateTime.Now.ToLongDateString();
            label2.Text=DateTime.Now.ToShortTimeString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStocks_Click(object sender, EventArgs e)
        {
            StocksInfo frm = new StocksInfo();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
