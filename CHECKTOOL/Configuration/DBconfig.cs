using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using DotNetEnv;

namespace CHECKTOOL.Configuration
{
    public class DBconfig
    {
        private readonly string _connectionString;
        public DBconfig()
        {
            Env.Load(); // Nếu .env nằm ở thư mục khác, truyền vào đường dẫn: Env.Load("Configs/.env");

            string host = GetRequiredEnv("DB_HOST");
            string port = GetRequiredEnv("DB_PORT");
            string db = GetRequiredEnv("DB_NAME");
            string user = GetRequiredEnv("DB_USER");
            string pass = GetRequiredEnv("DB_PASSWORD");

            _connectionString = $"Server={host};Database={db};User Id={user};Password={pass};Port={port}";
        }

        // Hàm hỗ trợ kiểm tra biến môi trường
        private string GetRequiredEnv(string key)
        {
            var value = Environment.GetEnvironmentVariable(key);
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidOperationException($"Biến môi trường '{key}' không được thiết lập hoặc rỗng. Vui lòng kiểm tra file .env.");
            }
            return value;
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
