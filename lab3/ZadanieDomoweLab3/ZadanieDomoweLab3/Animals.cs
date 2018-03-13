using System.Data;
using System.Data.SqlClient;


namespace ZadanieDomoweLab3
{
    class Animals
    {
        /// <summary>
        /// Funkcja służy do wybrania tabeli zwierząt i ilości danych w niej zawartych  
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="animalsInfo"></param>
        /// <param name="feedingInfo"></param>
        /// <returns></returns>
        public static DataTable GetAll(SqlConnection connection, bool animalsInfo, bool feedingInfo)
        {
            DataTable table = new DataTable();
            string info = "";

            if (animalsInfo == true)
            {
                info += ",B.TypeOfAnAnimal, B.Climate ";
            }
            if (feedingInfo == true)
            {
                info += ",E.FoodForAnimal, E.HowManyTimesFed ";
            }

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT A.Id, A.NameOfTheAnimal, A.HowManyAnimals " + info +
                " FROM  Animals as A " +
                " INNER JOIN  BasicInfo as B ON  A.BasicInfoId = B.Id " +
                " INNER JOIN  EmployeesInfo as E ON  A.EmployeesInfoId = E.Id ", connection);

            adapter.Fill(table);

            return table;
        }
    }
}
