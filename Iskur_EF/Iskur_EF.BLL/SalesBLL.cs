using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class SalesBLL
    {
        public static object GetSalesPeople()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.SalesPersons.Select(
                x => new
                {
                    x.Employee.Person.FirstName,
                    x.Employee.Person.LastName
                }
                );
            return result.ToList(); 
        }
        public static void addToComment()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            //dataContext
        }

        public static List<SalesTerritory> GetTerritories()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            return dataContext.SalesTerritories.ToList();

        }
    }
}
