using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FynBusSystem
{
    class DataAccessLayer
    {
        static private SqlConnection DatabaseConnection()
        {
            SqlConnection connection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL63_DB;" +
                "User Id=ejl63_usr;" +
                "Password=Baz1nga63;");
            return connection;
    }
        public void SaveSpreadSheetRow()
        {

        }
        public void LoadColumnsFromDatabase()
        {
            SqlConnection connection = DatabaseConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("LoadColumns", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
