using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementProject.Models;

namespace StockManagementProject.DAL
{
    
 public class CategoryRepository
 {
     private string _conString = ConString.DbConnection();

     public bool Add(Category category)
     {
         SqlConnection con=new SqlConnection(_conString);
         string query = "insert into category(name)values(@name)";
            SqlCommand cmd=new SqlCommand(query,con);
         cmd.Parameters.AddWithValue("@name",category.Name);

            con.Open();
         bool isAdded = cmd.ExecuteNonQuery() > 0;
         con.Close();
         return isAdded;

     }


 }
}
