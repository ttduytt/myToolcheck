using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHECKTOOL.Configuration;
using Microsoft.Identity.Client;
using MySqlConnector;

namespace CHECKTOOL.Model
{
    public class BarcodeModel
    {
        public bool alreadyExist(String barcode)
        {
            DBconfig dBconfig = new DBconfig();
            using (var conn = dBconfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM barcode WHERE barcode = @barcode";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result > 0;
                }
            }
        }

        public bool addBarcode(String barcode)
        {
            DBconfig dBconfig = new DBconfig();
            using (var conn = dBconfig.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO BARCODE (barcode) VALUES (@barcode)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
