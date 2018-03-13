using System.Data;
using System.Data.SqlClient;

namespace ZadanieDomoweLab3
{
    class ForVisitors
    {
        /// <summary>
        /// Funkcja służy do wybrania tabeli dla odwiedzających na podstawie otrzymanego napisu
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="whichTableToShow"></param>
        /// <returns></returns>
        public static DataTable GetAll(SqlConnection connection, string whichTableToShow)
        {
            if (whichTableToShow == "Ilość odwiedzających")
            {
                whichTableToShow = "Visitors";
            }
            else if (whichTableToShow == "Ceny biletów")
            {
                whichTableToShow = "TicketPrice";
            }

            SqlDataAdapter adapter = new SqlDataAdapter("select * from " + whichTableToShow, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
