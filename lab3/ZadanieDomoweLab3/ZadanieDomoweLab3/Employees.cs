using System.Data;
using System.Data.SqlClient;

namespace ZadanieDomoweLab3
{
    class Employees
    {
        /// <summary>
        /// Funkcja obsługuje wybór tabeli pracowników 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static DataTable GetEmployees(SqlConnection connection, string pattern)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select E.Id, E.Name, E.Surname, E.PESEL, W.Job, W.Salary " +
                " FROM  Employees as E" +
                " INNER JOIN WorkType as W ON  E.JobId = W.Id " +
                $" where Surname like '%{pattern}%'", connection);

            adapter.Fill(table);

            return table;
        }
    }
}
