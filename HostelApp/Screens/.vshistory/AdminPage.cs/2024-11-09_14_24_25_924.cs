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
    }
}
