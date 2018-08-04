using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementProject.Models;
using StockManagementProject.DAL;

namespace StockManagementProject.DAL
{
    
 public class CategoryRepository
 {
        
    SqlConnection _con = Connection.ConnectionSetup;
    

        public bool Add(Category category)
     {
        
            string query = "insert into category(name)values(@name)";
            SqlCommand cmd=new SqlCommand(query,_con);
         cmd.Parameters.AddWithValue("@name",category.Name);

           // _con.Open();
         bool isAdded = cmd.ExecuteNonQuery() > 0;
         _con.Close();
         return isAdded;

     }

     public bool Update(Category category)
     {
      
            string query = "update category set name=@name where id=id";
            SqlCommand cmd=new SqlCommand(query,_con);
         cmd.Parameters.AddWithValue("@name", category.Name);
        // cmd.Parameters.AddWithValue("@id", category.Id);
            _con.Open();
         bool update = cmd.ExecuteNonQuery() > 0;
            _con.Close();
         return update;

     }


 }
}
