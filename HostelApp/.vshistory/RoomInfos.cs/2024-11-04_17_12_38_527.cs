using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BUTTONINFO ORDER BY ID", link);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewRooms.DataSource = ds.Tables[0];
            link.Close();
        }

        private void ClrRomTbl_Click(object sender, EventArgs e)
        {
            DialogResult confirmaton = MessageBox.Show("All data for buttons will be deleted, are you sure?", "Deleting button data.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        bool IsOccupied;

        private void dataGridViewRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRooms.CurrentRow != null)
            {
                SelectedRow = dataGridViewRooms.CurrentRow.Cells["ButtonName"].Value.ToString();
                IsOccupied = Convert.ToBoolean(dataGridViewRooms.CurrentRow.Cells["IsOccupied"].Value);
            }
        }

        private void dataGridViewRooms_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRooms.Columns[e.ColumnIndex].Name == "IsOccupied" && dataGridViewRooms.CurrentRow != null)
            {
                IsOccupied = Convert.ToBoolean(dataGridViewRooms.CurrentRow.Cells["IsOccupied"].Value);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand cmd = new SqlCommand("UPDATE BUTTONINFO SET IsOccupied = @pIsOccupied WHERE ButtonName = @pButtonName", link);
            cmd.Parameters.AddWithValue("@pButtonName", SelectedRow);
            cmd.Parameters.AddWithValue("@pIsOccupied", IsOccupied);
            cmd.ExecuteNonQuery();
            link.Close();

            MessageBox.Show("Room occupancy status updated successfully.");
        }
    }
}
