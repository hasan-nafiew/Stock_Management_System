using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementProject.Models
{
  public static class ConString
    {
        public static string DbConnection()
        {
            string conString ="Server=ADORE\\SQLEXPRESS; Integrated Security=true;Database=StockMS";
            return conString;
        }
    }
}
