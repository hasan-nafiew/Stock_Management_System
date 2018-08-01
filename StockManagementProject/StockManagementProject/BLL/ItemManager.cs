using StockManagementProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementProject.Models;

namespace StockManagementProject.BLL
{
  public  class ItemManager
    {
        ItemRepository itemRepository = new ItemRepository();

        public bool IsInsert(Item item)
        {
            bool isInserted = itemRepository.Add(item);
            return isInserted;
            
                
        }
    }
}
