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

/*SqlCommand cmd = new SqlCommand("SELECT * FROM CUSTOMERINFO WHERE Id=@pId,Name=@pName,Surname=@pSurname,Gender=@pGender,PhoneNo=@pPhoneNo,Mail=@pMail,IDNO=@pIDNO,RoomNo=@pRoomNo,CheckInDate=@pCheckInDate,CheckOutDate=@pCheckOutDate,Price=@pPrice");
           cmd.Parameters.AddWithValue("@pId",);*/

namespace HostelApp
{
    public partial class CustomerInfos : Form
    {
        public CustomerInfos()
        {
            InitializeComponent();
            ShowInfos();
        }
        SqlConnection link = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orhan Bayrak\Desktop\Yazilim\CS_SQL\HostelApp\HostelApp\HostelDB.mdf;Integrated Security=True");
        public void ShowInfos()
        {
            link.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CUSTOMERINFO ORDER BY ID", link);//Filling the data table with data retrieved from the database.
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewCustomers.DataSource = ds.Tables[0];
            link.Close();
        }

        //BAŞLANGIIIIIIÇ
        private void register_button_Click(object sender, EventArgs e)//Adding new values.
        {

        }
        string SelectedRowID;
        private void delete_buttonClick(object sender, EventArgs e)//Deleting the selected row.
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)//Selecting the wanted row.
        {

            SelectedRowID = (dataGridView1.CurrentRow.Cells["Id"].Value).ToString();
            lblRowIndex.Text = SelectedRowID.ToString();
            textBox6.Text = (dataGridView1.CurrentRow.Cells["Name"].Value).ToString();
            textBox7.Text = (dataGridView1.CurrentRow.Cells["Surname"].Value).ToString();
            textBox8.Text = (dataGridView1.CurrentRow.Cells["ID_NO"].Value).ToString();
            textBox9.Text = (dataGridView1.CurrentRow.Cells["Birth_date"].Value).ToString();
            textBox10.Text = (dataGridView1.CurrentRow.Cells["Birth_place"].Value).ToString();

        }

        private void edit_buttonClick(object sender, EventArgs e)
        {

        }


        //
    }
}
