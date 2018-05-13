using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Fibonacci.Core.DataBase
{
    public static class DataBaseFacade
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Fibonacci"].ToString();
        public static IEnumerable<T> Query<T>(string query, object param)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                return con.Query<T>(query, param);
            }
        }
        public static int Execute(string query, object param)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                return con.Execute(query, param);
            }
        }
    }
}
