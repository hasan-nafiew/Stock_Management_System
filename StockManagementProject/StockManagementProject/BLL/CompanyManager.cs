using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementProject.DAL;
using StockManagementProject.Models;

namespace StockManagementProject.BLL
{
   public class CompanyManager
    {
        CompanyRepository companyRepository=new CompanyRepository();

        public bool IsInserted(Company company)
        {
            if (company.Name.Length<3)
            {
                throw new Exception("Name must be greater than 3 character");
            }
            bool isAdded = companyRepository.Add(company);
            return isAdded;
        }

    }
}
