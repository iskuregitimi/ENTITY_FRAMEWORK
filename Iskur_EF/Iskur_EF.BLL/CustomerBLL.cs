using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class CustomerBLL
    {
        public static object GetCustomers(string searchText)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            var result = datacontext.Customers.Where(c => c.PersonID != null).Select(
                x => new
                {
                    x.CustomerID,
                    x.Person.FirstName,
                    x.Person.LastName,
                    x.TerritoryID
                }
                );

            return result.ToList();
        }

    }
}
