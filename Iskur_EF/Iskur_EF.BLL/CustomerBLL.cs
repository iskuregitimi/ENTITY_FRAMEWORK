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
      static  AdventureWorksEntities datacontext = new AdventureWorksEntities();
        public static object GetCustomers(string searchText)
        {
           
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

        public static Customer GetCustomer(int customerıd)
        {
           return datacontext.Customers.Where(x => x.CustomerID == customerıd).FirstOrDefault();
        }

    }
}
