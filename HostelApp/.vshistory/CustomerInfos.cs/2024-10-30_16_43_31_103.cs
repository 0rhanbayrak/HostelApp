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
        
        string SelectedRowID;
        private void delete_button_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand cmd = new SqlCommand("DELETE  FROM CUSTOMERINFO WHERE Id=@pId", link);
            cmd.Parameters.AddWithValue("@pId", Convert.ToInt32(SelectedRowID));
            cmd.ExecuteNonQuery();
            link.Close();
        }
        /*
private void dataGridView1_SelectionChanged(object sender, EventArgs e)//Selecting the wanted row.
{

  SelectedRowID = (dataGridViewCustomers.CurrentRow.Cells["Id"].Value).ToString();
  lblRowIndex.Text = SelectedRowID.ToString();
  textBox6.Text = (dataGridViewCustomers.CurrentRow.Cells["Name"].Value).ToString();
  textBox7.Text = (dataGridViewCustomers.CurrentRow.Cells["Surname"].Value).ToString();
  textBox8.Text = (dataGridViewCustomers.CurrentRow.Cells["ID_NO"].Value).ToString();
  textBox9.Text = (dataGridViewCustomers.CurrentRow.Cells["Birth_date"].Value).ToString();
  textBox10.Text = (dataGridViewCustomers.CurrentRow.Cells["Birth_place"].Value).ToString();

}

private void edit_buttonClick(object sender, EventArgs e)
{
  link.Open();
  SqlCommand cmd = new SqlCommand("UPDATE CUSTOMERINFO SET Id=@pId,Name=@pName,Surname=@pSurname,Gender=@pGender,PhoneNo=@pPhoneNo,Mail=@pMail,IDNO=@pIDNO,RoomNo=@pRoomNo,CheckInDate=@pCheckInDate,CheckOutDate=@pCheckOutDate,Price=@pPrice", link);
  cmd.Parameters.AddWithValue("@pName", textBox6.Text);
  cmd.Parameters.AddWithValue("@pSurname", textBox7.Text);
  cmd.Parameters.AddWithValue("@pID_NO", textBox9.Text);
  cmd.Parameters.AddWithValue("@pBirth_date", textBox9.Text);
  cmd.Parameters.AddWithValue("@pBirth_place", textBox10.Text);
  cmd.Parameters.AddWithValue("@pID", SelectedRowID);
  cmd.ExecuteNonQuery();
  link.Close();
}

*/
        //
    }
}
