using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementProject.Models
{
 public  class Item
    {
        public string Name { get; set; }
        public int Reorderlevel { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }

    }
}
