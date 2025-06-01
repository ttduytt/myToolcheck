using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace CHECKTOOL.Configuration
{
    public class DBconfig
    {
        private readonly string _connectionString;
        public DBconfig()
        {
            _connectionString = "Server=localhost;Database=db_checktoool;User Id=root;Password=1111;Port=3306";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    Console.WriteLine("Kết nối thành công!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kết nối thất bại: " + ex.Message);
                return false;
            }
        }
    }
}
