using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementProject.Models;
using System.Data.SqlClient;

namespace StockManagementProject.DAL
{
  public  class ItemRepository
    {
        SqlConnection _con = Connection.ConnectionSetup;
       public bool Add(Item item)
        {
            
           
            string query = "insert into item(name,reorderlevel,categoryId,companyId) values(@name,@reorderlevel,@categoryId,@companyId)";
            SqlCommand cmd = new SqlCommand(query, _con);
            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@reorderlevel", item.Reorderlevel);
            cmd.Parameters.AddWithValue("@categoryId", item.CategoryId);
            cmd.Parameters.AddWithValue("@companyId", item.CompanyId);
           // con.Open();
            bool isAdded = cmd.ExecuteNonQuery() > 0;
            _con.Close();
            return isAdded;

        }
    }
}
