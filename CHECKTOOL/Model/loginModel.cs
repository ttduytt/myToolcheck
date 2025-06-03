using CHECKTOOL.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHECKTOOL.Model
{
    public class loginModel
    {
        public bool AuthenticateUser(string username, string password)
        {
            DBconfig dbconfig =new DBconfig();  
            using (var conn = dbconfig.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result > 0;
                }
            }
        }
    }

}

    

