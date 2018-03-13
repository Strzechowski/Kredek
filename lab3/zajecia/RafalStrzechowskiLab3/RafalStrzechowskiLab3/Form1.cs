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

namespace RafalStrzechowskiLab3
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=LAPTOP-TBU3K31F\SQLEXPRESS; database=RafalStrzechowskiLab3; Trusted_Connection = yes");

        }

        private void buttonFilm_Click(object sender, EventArgs e)
        {
            DataTable table = Film.GetAll(connection);

            dataGridViewFilm.DataSource = table;
        }
    }
}
