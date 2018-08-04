using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace StockManagementProject.DAL
{
  public static  class Connection
    {
        static string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        static SqlConnection _connection = null;

        public static SqlConnection ConnectionSetup
        {
            get
            {
                if(_connection==null)
                {
                    _connection = new SqlConnection(_conString);
                    _connection.Open();
                    return _connection;
                    
                }
                else if(_connection.State!=System.Data.ConnectionState.Open)
                {
                    _connection = new SqlConnection(_conString);
                    _connection.Open();
                    return _connection;
                }
                else
                {
                    return _connection;
                }
                
            }
        }

    }
}
