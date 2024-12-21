using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            if (textBoxPassword.Text.Length < 4)
            {
                MessageBox.Show("Password must have at least 4 characters!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ADMININFO (Username,Password) VALUES (@pUsername,@pPassword)", link);
                string hashedpassword = Sha256Converter.ComputeSha256Hash(textBoxPassword.Text);
                cmd.Parameters.AddWithValue("@pUsername", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@pPassword", hashedpassword);
                cmd.ExecuteNonQuery();  
            }
            link.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminPage frm = new AdminPage();
            frm.Show();
            this.Hide();
        }
    }
}
