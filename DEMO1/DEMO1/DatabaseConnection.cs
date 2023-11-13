using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace DEMO1
{
        public class DatabaseConnection
        {
            private static string ConnectionString = @"Data Source=DESKTOP-BEI8NT7;Initial Catalog=Trainning;Integrated Security=True; TrustServerCertificate=True;";

            public static string GetStrConnection()
            {
                return ConnectionString;
            }

            public static SqlConnection GetSqlConnection()
            {
                string strConnection = GetStrConnection();
                SqlConnection connection = new SqlConnection(strConnection);
                return connection;
            }
        }
}
