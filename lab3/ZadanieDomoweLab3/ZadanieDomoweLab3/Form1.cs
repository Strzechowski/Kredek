using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ZadanieDomoweLab3
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            connection = new SqlConnection(@"Data Source=LAPTOP-TBU3K31F\SQLEXPRESS; database=ZadanieDomoweLab3; Trusted_Connection = yes");
            InitializeComponent();
        }


        /// <summary>
        /// Obsługa przycisku wyświetlania tabeli dla odwiedzających na podstawie tekstu z comboBoxa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForVisitors_Click(object sender, EventArgs e)
        {
            DataTable table = ForVisitors.GetAll(connection, comboBoxForVisitors.Text);
            dataGridViewForVisitors.DataSource = table;
        }


        /// <summary>
        /// Obsługa przycisku wyświetlającego tabelę ze zwierzętami na podstawie checkBoxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowAnimals_Click(object sender, EventArgs e)
        {
            DataTable table = Animals.GetAll(connection, checkBoxAnimalsInfo.Checked, checkBoxFeedingInfo.Checked);
            dataGridViewAnimals.DataSource = table;
        }


        /// <summary>
        /// Obsługa przycisku do wyświetlania pracowników w tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowEmployees_Click(object sender, EventArgs e)
        {
            DataTable table = Employees.GetEmployees(connection, textBoxEmployeesSurnameLike.Text);
            dataGridViewEmployees.DataSource = table;
        }

        /// <summary>
        /// Obsługa przyisku do wyświetlania grafiku pracowników w tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowWorkSchedule_Click(object sender, EventArgs e)
        {
            DataTable table = WorkSchedule.GetEmployees(connection, textBoxEmployeesSurnameLike.Text);
            dataGridViewEmployees.DataSource = table;
        }
    }
}
