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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostelApp
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            SqlConnection link = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orhan Bayrak\Desktop\Yazilim\CS_SQL\HostelApp\HostelApp\HostelDB.mdf;Integrated Security=True");
            link.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ADMININFO WHERE Username=@pUsername AND Password=@pPassword", link);

            cmd.Parameters.AddWithValue("@pUsername",textBoxUsername.Text);
            cmd.Parameters.AddWithValue("@pPassword", textBoxPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CustomerInfos frm = new CustomerInfos();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
                MainScreen frm = new MainScreen();
                frm.Show();
                this.Close();
        }
    }
}
