using DotNetEnv;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CHECKTOOL.Configuration
{
    public class DBconfig
    {
        private const int MAX_BUFFER = 255;
        private readonly string _iniPath;
        private string _connectString;
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(
            string section, string key, string defaultValue,
            StringBuilder returnValue, int size, string filePath);

        public DBconfig()
        {
            _iniPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "localConfig.ini");
            if (!File.Exists(_iniPath))
            {
                throw new FileNotFoundException("File cấu hình không tồn tại: " + _iniPath);
            }
        }

        // đọc dữ liệu từ file
        private string ReadValue(string section, string key)
        {
            StringBuilder buffer = new StringBuilder(MAX_BUFFER);
            GetPrivateProfileString(section, key, "", buffer, buffer.Capacity, _iniPath);
            return buffer.ToString();
        }

        public MySqlConnection GetConnection()
        {
            string host = ReadValue("DB", "DB_HOST");
            string port = ReadValue("DB", "DB_PORT");
            string user = ReadValue("DB", "DB_USER");
            string pass = ReadValue("DB", "DB_PASSWORD");
            string db = ReadValue("DB", "DB_NAME");

            _connectString = $"Server={host};Database={db};User Id={user};Password={pass};Port={port};";
            return new MySqlConnection(_connectString);
        }
    }
}
