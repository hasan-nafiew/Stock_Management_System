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
      string _conString = ConString.DbConnection();
    

        public bool Add(Category category)
     {
         SqlConnection _con = new SqlConnection(_conString);
            string query = "insert into category(name)values(@name)";
            SqlCommand cmd=new SqlCommand(query,_con);
         cmd.Parameters.AddWithValue("@name",category.Name);

            _con.Open();
         bool isAdded = cmd.ExecuteNonQuery() > 0;
         _con.Close();
         return isAdded;

     }

     public bool Update(Category category)
     {
         SqlConnection _con = new SqlConnection(_conString);
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
