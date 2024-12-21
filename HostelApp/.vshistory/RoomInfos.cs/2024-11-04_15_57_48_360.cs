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
using static System.Windows.Forms.LinkLabel;

namespace HostelApp
{
    public partial class RoomInfos : Form
    {
        public RoomInfos()
        {
            InitializeComponent();
            ShowInfos();
        }
        SqlConnection link = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orhan Bayrak\Desktop\Yazilim\CS_SQL\HostelApp\HostelApp\HostelDB.mdf;Integrated Security=True");

        public void ShowInfos()
        {
            link.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BUTTONINFO ORDER BY ID", link);//Filling the data table with data retrieved from the database.
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewRooms.DataSource = ds.Tables[0];
            link.Close();
        }

        private void ClrRomTbl_Click(object sender, EventArgs e)
        {
            DialogResult confirmaton = MessageBox.Show("All data for buttons will be deleted,are you sure?", "Deleting button data.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmaton == DialogResult.Yes)
            {
                link.Open();
                SqlCommand cmd = new SqlCommand("TRUNCATE TABLE BUTTONINFO", link);
                cmd.ExecuteNonQuery();
                link.Close();
                ShowInfos();
            }
        }
        string SelectedRow;
        int IsOccupied;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand cmd = new SqlCommand("UPDATE BUTTONINFO SET IsOccupied=@pIsOccupied WHERE ButtonName=@pButtonName", link);
            cmd.Parameters.AddWithValue("@pButtonName",SelectedRow);
            cmd.Parameters.AddWithValue("@pIsOccupied", SelectedRow);
        }

        private void dataGridViewRooms_SelectionChanged(object sender, EventArgs e)
        {
           SelectedRow=(dataGridViewRooms.CurrentRow.Cells[0].Value).ToString();
            IsOccupied = dataGridViewRooms.CurrentRow.Cells[1].Value;
        }
    }
}
