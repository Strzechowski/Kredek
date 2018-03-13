using System.Data;
using System.Data.SqlClient;


namespace ZadanieDomoweLab3
{
    class WorkSchedule
    {
        /// <summary>
        /// Funkcja obsługuje wybór tabeli z grafikiem opiekunów zwierząt
        /// </summary>
        /// <param name="connection"></param>d
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static DataTable GetEmployees(SqlConnection connection, string pattern)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select W.Id, E.Name, E.Surname, A.NameOfTheAnimal, B.NameOfTheBuilding " +
                " FROM  WorkSchedule as W" +
                " INNER JOIN Employees as E ON  W.EmployeeId = E.Id " +
                " INNER JOIN Animals as A ON  W.AnimalId = A.Id " +
                " INNER JOIN Buildings as B ON  W.BuildingId = B.Id " +
                $" where Surname like '%{pattern}%'"
                , connection);

            adapter.Fill(table);

            return table;
        }
    }
}
