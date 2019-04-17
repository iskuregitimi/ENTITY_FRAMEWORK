using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
   public static class SalesPErsonBLL
    {
        public static  object GetSalesPeople(string searchText)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            var result = datacontext.SalesPersons.Select(

                x => new
                {


                    x.Employee.Person.FirstName
                }
                );
            return result.ToList();



        }
    }
}
