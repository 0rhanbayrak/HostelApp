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
            ShowInfos();
        }
        
        string SelectedRowID;
        private void delete_button_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM CUSTOMERINFO WHERE Id=@pId", link);
            cmd.Parameters.AddWithValue("@pId", Convert.ToInt32(SelectedRowID));
            cmd.ExecuteNonQuery();
            link.Close();
            ShowInfos();
        }

        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            SelectedRowID = (dataGridViewCustomers.CurrentRow.Cells["Id"].Value).ToString();
            label8.Text= SelectedRowID;
            EtextBoxName.Text = (dataGridViewCustomers.CurrentRow.Cells["Name"].Value).ToString() ;
            EtextBoxSurname.Text= (dataGridViewCustomers.CurrentRow.Cells["Surname"].Value).ToString();
            comboBox2.Text= (dataGridViewCustomers.CurrentRow.Cells["Gender"].Value).ToString();
            EtextBoxPhoneNo.Text= (dataGridViewCustomers.CurrentRow.Cells["PhoneNo"].Value).ToString();
            EtextBoxMail.Text= (dataGridViewCustomers.CurrentRow.Cells["Mail"].Value).ToString();
            EtextBoxIDNO.Text= (dataGridViewCustomers.CurrentRow.Cells["IDNO"].Value).ToString();
            EtextBoxRoomNo.Text= (dataGridViewCustomers.CurrentRow.Cells["RoomNo"].Value).ToString();
            /*dateTimePicker3.Value= (dataGridViewCustomers.CurrentRow.Cells["CheckInDate"].Value).ToString();
            dateTimePicker4.Value= (dataGridViewCustomers.CurrentRow.Cells["CheckOutDate"].Value).ToString();*/
            EtextBoxPrice.Text= (dataGridViewCustomers.CurrentRow.Cells["Price"].Value).ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CUSTOMERINFO SET Name=@pName,Surname=@pSurname,Gender=@pGender,PhoneNo=@pPhoneNo,Mail=@pMail,IDNO=@pIDNO,RoomNo=@pRoomNo,CheckInDate=@pCheckInDate,CheckOutDate=@pCheckOutDate,Price=@pPrice WHERE Id=@pId", link);
            cmd.Parameters.AddWithValue("@pId",SelectedRowID);
            cmd.Parameters.AddWithValue("@pName", EtextBoxName.Text);
            cmd.Parameters.AddWithValue("@pSurname", EtextBoxSurname.Text);
            cmd.Parameters.AddWithValue("@pGender", comboBox2.Text);
            cmd.Parameters.AddWithValue("@pPhoneNo", EtextBoxPhoneNo.Text);
            cmd.Parameters.AddWithValue("@pMail", EtextBoxMail.Text);
            cmd.Parameters.AddWithValue("@pIDNO", EtextBoxIDNO.Text);
            cmd.Parameters.AddWithValue("@pRoomNo", EtextBoxRoomNo.Text);
            cmd.Parameters.AddWithValue("@pCheckInDate", dateTimePicker3.Value);
            cmd.Parameters.AddWithValue("@pCheckOutDate", dateTimePicker4.Value);
            cmd.Parameters.AddWithValue("@pPrice",EtextBoxPrice.Text);
            cmd.ExecuteNonQuery();//Applying the add operation.
            link.Close();
            //editButton.BackColor=System.Drawing.Color.Red;
            ShowInfos();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainScreen frm = new MainScreen();
            frm.Show();
            this.Close();
        }

        private void TrnctCstmr_Click(object sender, EventArgs e)
        {
            DialogResult confirmaton = MessageBox.Show("All data for costumers will be deleted,are you sure?","Deleting cutomer data.",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirmaton == DialogResult.Yes)
            {
                link.Open();
                SqlCommand cmd = new SqlCommand("TRUNCATE TABLE CUSTOMERINFO", link);
                cmd.ExecuteNonQuery();
                link.Close();
                ShowInfos();
            }
         }

        private void GoToRomTbl_Click(object sender, EventArgs e)
        {
            RoomInfos frm = new RoomInfos();
            frm.Show();
            this.Close();
        }
    }
}
