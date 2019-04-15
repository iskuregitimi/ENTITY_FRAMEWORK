using Iskur_Ef.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
   public static class CustomerBLL
    {
        public static object GetCustomer(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.Customers.Where(c => c.PersonID != null).Select(x => new
            {
                x.CustomerID,
                x.PersonID,
                x.Person.LastName,
                x.TerritoryID,

            });
            return result.ToList();
        }
        public static Customer GetCustomerDetails(int CustomerId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Customers.Where(x => x.CustomerID == CustomerId).FirstOrDefault();
                        
                //return dataContext.Employees.Where(x => x.BusinessEntityID == BusinessEntityId).FirstOrDefault();

        }
        //public static Customer GetOrderDetails(int CustomerId)




    }
}
