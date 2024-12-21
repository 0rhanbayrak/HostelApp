using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostelApp
{
       
        public partial class CustomerRegister : Form
        {
            SqlConnection link = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orhan Bayrak\Desktop\Yazilim\CS_SQL\HostelApp\HostelApp\HostelDB.mdf;Integrated Security=True");
            public CustomerRegister()
            {
                InitializeComponent();
            }
            private void Btn101_Click(object sender, EventArgs e)
            { 
                link.Open();
                int IsOccupied=0;
                IsOccupied++;
                SqlCommand cmd = new SqlCommand("INSERT INTO BUTTONINFO (ButtonName,IsOccupied) VALUES (@pButtonName,@pIsOccupied)",link);
                cmd.Parameters.AddWithValue("@pButtonName", Btn101.Name);
                cmd.Parameters.AddWithValue("@pIsOccupied", IsOccupied);
                cmd.ExecuteNonQuery();
                link.Close();    
        }

            private void Btn102_Click(object sender, EventArgs e)
            {
                textBoxRoomNo.Text = Btn102.Text;
            }

            private void Btn103_Click(object sender, EventArgs e)
            {
                textBoxRoomNo.Text = Btn103.Text;
            }

            private void Btn201_Click(object sender, EventArgs e)
            {
                textBoxRoomNo.Text = Btn201.Text;
            }

            private void Btn202_Click(object sender, EventArgs e)
            {
                textBoxRoomNo.Text = Btn202.Text;
            }

            private void Btn203_Click(object sender, EventArgs e)
            {
                textBoxRoomNo.Text = Btn203.Text;
            }

            private void Btn301_Click(object sender, EventArgs e)
            {
                textBoxRoomNo.Text = Btn301.Text;
            }

            private void Btn302_Click(object sender, EventArgs e)
            {
                textBoxRoomNo.Text = Btn302.Text;       
            }

            private void Btn303_Click(object sender, EventArgs e)
            {
                textBoxRoomNo.Text = Btn303.Text;
            }
            
        private void CheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            int price;
            DateTime checkInDate=Convert.ToDateTime(CheckInDate.Text);
            DateTime checkOutDate = Convert.ToDateTime(CheckOutDate.Text);

            int totalDays;
            totalDays = (checkOutDate - checkInDate).Days;
            price = totalDays * 20;
            lblPrice.Text = price.ToString()+" $";
        }
        
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection link=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orhan Bayrak\Desktop\Yazilim\CS_SQL\HostelApp\HostelApp\HostelDB.mdf;Integrated Security=True");
            link.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMERINFO (Name,Surname,Gender,PhoneNo,Mail,IDNO,RoomNo,CheckInDate,CheckOutDate,Price) VALUES (@pName,@pSurname,@pGender,@pPhoneNo,@pMail,@pIDNO,@pRoomNo,@pCheckInDate,@pCheckOutDate,@pPrice)", link);
            cmd.Parameters.AddWithValue("@pName",textBoxName.Text);
            cmd.Parameters.AddWithValue("@pSurname", textBoxSurname.Text);
            cmd.Parameters.AddWithValue("@pGender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@pPhoneNo", maskedTextBoxPhoneNo.Text);
            cmd.Parameters.AddWithValue("@pMail", textBoxMail.Text);
            cmd.Parameters.AddWithValue("@pIDNO", textBoxIdNo.Text);
            cmd.Parameters.AddWithValue("@pRoomNo", textBoxRoomNo.Text);
            cmd.Parameters.AddWithValue("@pCheckInDate", CheckInDate.Value);
            cmd.Parameters.AddWithValue("@pCheckOutDate", CheckOutDate.Value);
            cmd.Parameters.AddWithValue("@pPrice", lblPrice.Text);
            cmd.ExecuteNonQuery();//Applying the add operation.
            MessageBox.Show("Register completed.");
            link.Close();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
           MainScreen frm = new MainScreen();
           frm.Show();   
           this.Close();
            
        }
    }
}
