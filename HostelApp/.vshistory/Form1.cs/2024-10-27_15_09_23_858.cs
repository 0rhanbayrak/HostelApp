using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelApp
{
    public partial class CustomerRegister : Form
    {
        public CustomerRegister()
        {
            InitializeComponent();
        }

        private void Btn101_Click(object sender, EventArgs e)
        {
            textBoxRoomNo.Text = Btn101.Text;
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

            TimeSpan totalDays;
            totalDays = checkOutDate - checkInDate;
            price = Convert.ToInt32(totalDays) * 20;
            
        }
    }
}
