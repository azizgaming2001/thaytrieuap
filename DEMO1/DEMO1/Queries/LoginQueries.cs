using DEMO1.Models;
using Microsoft.Data.SqlClient;

namespace DEMO1.Queries
{
    public class LoginQueries
    {
        //chua cac logic sql xu ly voi database
        public LoginModel CheckLoginUser(string username, string password)
        {
            LoginModel dataUser = new LoginModel();
            using (SqlConnection conn = DatabaseConnection.GetSqlConnection())
            {
                string querySql = "SELECT * FROM users WHERE username = @username AND password = @password";
                //@username and @password : tham so truyen vao cau lenh sql voi gia tru dc nhan tu 2 bien strong va username vaf string password
                //tao 1 doi tuong de thuc thi cau lenh sql
                SqlCommand cmd = new SqlCommand(querySql, conn);
                //xu ly truyen gia tri cho tham gi sql
                cmd.Parameters.AddWithValue("@username", username ??(object)DBNull.Value);
                cmd.Parameters.AddWithValue("@password", password ??(object)DBNull.Value);
                //mo ket noi data base
                conn.Open();
                //thuc thi lenh sql
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        //do du lieu tu table trong database vao model minh da dinh nghia
                        dataUser.UserID = reader["id"].ToString();
                        dataUser.Username = reader["username"].ToString();
                        dataUser.Email = reader["email"].ToString();
                        dataUser.RoleID = reader["role_id"].ToString();
                        dataUser.PhoneUser = reader["phone"].ToString();
                        dataUser.FullName = reader["full_name"].ToString();
                        dataUser.ExtraCode = reader["extra_code"].ToString();


                    }
                    //ngatketnoidatabase
                    conn.Close();
                }
            }
                return dataUser;
        }
    }
}
