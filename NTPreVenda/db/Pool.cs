using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace NTPreVenda.db
{
    internal class Pool
    {
        //private const string connectionString = "Server=192.168.88.253;Database=BDLJNTEXTILNCLASS;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true;";
        // private const string connectionString = "Server=192.168.88.253;Database=BDLJNTEXTILNCLASS;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true;";
        public const string connectionString = "Server=192.168.88.253;Database=BDLJNTEXTILNCLASS;User Id=SA;Password=inter#system;TrustServerCertificate=true;";

        public static string LastError = string.Empty;
        public static SqlConnection GetConnectionNot()
        {
            try
            {
                return new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }


        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
        public static async Task<SqlConnection> GetConnectionAsync()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                return connection;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }

        public static async void CloseConnecton(SqlConnection m)
        {
            await m.CloseAsync();
        }
    }

}
