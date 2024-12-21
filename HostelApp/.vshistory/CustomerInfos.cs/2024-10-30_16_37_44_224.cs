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

        private void register_button_Click_1(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMERINFO (Name,Surname,Gender,PhoneNo,Mail,IDNO,RoomNo,CheckInDate,CheckOutDate,Price) VALUES (@pName,@pSurname,@pGender,@pPhoneNo,@pMail,@pIDNO,@pRoomNo,@pCheckInDate,@pCheckOutDate,@pPrice)", link);
            cmd.Parameters.AddWithValue("@pName", RtextBoxName.Text);
            cmd.Parameters.AddWithValue("@pSurname", RtextBoxSurname.Text);
            cmd.Parameters.AddWithValue("@pGender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@pPhoneNo", RtextBoxPhoneNo.Text);
            cmd.Parameters.AddWithValue("@pMail", RtextBoxMail.Text);
            cmd.Parameters.AddWithValue("@pIDNO", RtextBoxIDNO.Text);
            cmd.Parameters.AddWithValue("@pRoomNo", RtextBoxRoomNo.Text);
            cmd.Parameters.AddWithValue("@pCheckInDate",dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@pCheckOutDate", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@pPrice", RtextBoxPrice.Text);
            cmd.ExecuteNonQuery();//Applying the add operation.
            link.Close();
        }
    }
}
