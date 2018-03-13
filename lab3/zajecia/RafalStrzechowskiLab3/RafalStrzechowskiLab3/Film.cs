using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace RafalStrzechowskiLab3
{
    class Film
    {
        public static DataTable GetAll(SqlConnection connection)
        {
            // w klasie
            string film = "Film";
            SqlDataAdapter adapter = new SqlDataAdapter("select * from " + film , connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
