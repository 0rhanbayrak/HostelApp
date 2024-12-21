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

namespace HostelApp
{
    public partial class StocksInfo : Form
    {
        SqlConnection link = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orhan Bayrak\Desktop\Yazilim\CS_SQL\HostelApp\HostelApp\HostelDB.mdf;Integrated Security=True");
        public StocksInfo()
        {
            InitializeComponent();
        }

        private void StocksInfo_Load(object sender, EventArgs e)
        {  
            this.sTOCKSINFOTableAdapter.Fill(this.hostelDBDataSet.STOCKSINFO);
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            link.Open();
        }
    }
}
