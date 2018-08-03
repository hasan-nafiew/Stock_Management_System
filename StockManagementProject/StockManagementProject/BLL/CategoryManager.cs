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
        CategoryRepository _categoryRepository=new CategoryRepository();

        public bool IsInserted(Category category)
        {
            bool isInserted = _categoryRepository.Add(category);
            return isInserted;
        }
        public bool IsUpdate(Category category)
        {
            bool isUpdate = _categoryRepository.Update(category);
            return isUpdate;


        }
    }
    
}
