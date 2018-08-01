using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementProject.DAL;
using StockManagementProject.Models;

namespace StockManagementProject.BLL
{
  public  class CategoryManager
    {
        CategoryRepository categoryRepository=new CategoryRepository();

        public bool IsInserted(Category category)
        {
            bool isInserted = categoryRepository.Add(category);
            return isInserted;
        }
    }
}
