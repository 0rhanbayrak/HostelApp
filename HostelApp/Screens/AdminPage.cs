using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelApp.Screens
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void BtnCstmrTbl_Click(object sender, EventArgs e)
        {
            CustomerInfos frm = new CustomerInfos();
            frm.Show();
            this.Hide();
        }

        private void BtnRomTbl_Click(object sender, EventArgs e)
        {
            RoomInfos frm = new RoomInfos();
            frm.Show();
            this.Hide();
        }

        private void BtnNewAdm_Click(object sender, EventArgs e)
        {
            NewAdmin frm = new NewAdmin();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreen frm = new MainScreen();  
            frm.Show();
            this.Hide();
        }
    }
}
