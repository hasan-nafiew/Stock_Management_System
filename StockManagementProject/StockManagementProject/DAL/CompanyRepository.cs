using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementProject.Models;

namespace StockManagementProject.DAL
{
   public class CompanyRepository
    {
        public bool Add(Company company)
        {
            string conString = ConString.DbConnection();
            SqlConnection con=new SqlConnection(conString);
            string query = "insert into company(name)values(@name)";
            SqlCommand cmd=new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@name", company.Name);
            con.Open();
            bool isAdd = cmd.ExecuteNonQuery() > 0;
            con.Close();

            return isAdd;
        }
    }
}
