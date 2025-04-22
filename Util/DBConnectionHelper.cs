using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Util
{
    class DBConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = null;
            try
            {
                // Default connection string for MySQL (localhost, port 3306)
                string connectionString = "Server=DESKTOP-C2IRK4B\\SQLSERVER2022;Database=InsuranceManagementSystem;Integrated Security=True;TrustServerCertificate=True";

                // Establish connection to the database
                conn = new SqlConnection(connectionString);
                conn.Open();
                //Console.WriteLine("Database connected successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB Connection Error: " + ex.Message);
            }
            return conn;
        }
    }
}
