using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementProject.Models;

namespace StockManagementProject.DAL
{
   public class CompanyRepository
    {
        SqlConnection _con = Connection.ConnectionSetup;
        public bool Add(Company company)
        {
           
           
            string query = "insert into company(name)values(@name)";
            SqlCommand cmd=new SqlCommand(query,_con);
            cmd.Parameters.AddWithValue("@name", company.Name);
            //con.Open();
            bool isAdd = cmd.ExecuteNonQuery() > 0;
            _con.Close();

            return isAdd;
        }
        /*
        public Company GetCompany()
        {
            
            SqlConnection con = new SqlConnection(_conString);
            string query = "select id,name from company )";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            

            
          
            return comany;
        }*/
    }
}
