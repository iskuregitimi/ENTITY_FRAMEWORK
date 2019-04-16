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
        static AdventureWorksEntities dataContext = new AdventureWorksEntities();

        public static object GetAllCustomers()
        {
            var result = dataContext.Customers.Where(x=>x.PersonID != null).Select(x=> new
            {
                x.CustomerID,
                x.Person.FirstName,
                x.Person.LastName,
                x.TerritoryID
            });

            return result.ToList();
        }
    }
}
