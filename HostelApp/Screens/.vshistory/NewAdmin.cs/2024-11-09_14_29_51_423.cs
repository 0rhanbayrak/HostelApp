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
    public partial class NewAdmin : Form
    {
        public NewAdmin()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminPage frm = new AdminPage();
            frm.Show();
            this.Hide();
        }
    }
}
