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

            SqlCommand cmd = new SqlCommand("SELECT * FROM ADMININFO WHERE Username=@pUsername AND Password=@pPassword", link);//Giving the command.

            //string hashedPassword = Sha256Converter.ComputeSha256Hash(textBoxPassword.Text);//Converting the password.

            cmd.Parameters.AddWithValue("@pUsername", textBoxUsername.Text);//Specifying the address to receive the user name.
            cmd.Parameters.AddWithValue("@pPassword", textBoxPassword.Text);//Specifying the address to receive the password.
            /*SqlDataReader dr = cmd.ExecuteReader();//Executing the query and retrieve the results from the database.

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ADMININFO ORDER BY ID", link);//Filling the data table with data retrieved from the database.
            DataTable dt = new DataTable();
            da.Fill(dt);
            */
            if (textBoxUsername.Text="orhan")// If true.
            {
                link.Close();
               // Data_transfer.loggedUserName = dt.Rows[0]["User_name"].ToString();
                CustomerRegister frm = new CustomerRegister();
                frm.Show();
                this.Visible = false;
            }
            else   //If wrong.
            {
                MessageBox.Show("Wrong User Name or Password!");
            }

            link.Close();
        }
    }
}
