using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection link = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orhan Bayrak\Desktop\Yazilim\CS_SQL\HostelApp\HostelApp\HostelDB.mdf;Integrated Security=True");
        
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand cmd = new SqlCommand("",link);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminPage frm = new AdminPage();
            frm.Show();
            this.Hide();
        }
    }
}
