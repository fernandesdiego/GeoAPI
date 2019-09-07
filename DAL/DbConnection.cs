using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GeoAPI.DAL
{
    public class DbConnection
    {
        public static SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GeoAPIContext"].ConnectionString);
        public static void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed || Connection.State == ConnectionState.Broken)
            {
                Connection.Open();
            }
        }
        public static void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}