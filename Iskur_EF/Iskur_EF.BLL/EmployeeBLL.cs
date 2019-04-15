using Iskur_Ef.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
   public static  class EmployeeBLL
    {
        public static List<Employee> GetEmployees(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Employees.Take(100).ToList();
            
        }

        public static Employee GetPeople(int BusinessEntityId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Employees.Where(x => x.BusinessEntityID == BusinessEntityId).FirstOrDefault();

        }
        public static List<Store>GetStores(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Stores.Take(100).ToList();
        }
        public static   Store GetStoreDetails(int SalesId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Stores.Where(x => x.SalesPersonID == SalesId).FirstOrDefault();

            /*BusinessEntityID == BusinessEntityId).FirstOrDefault();*/

        }
        //public static List<Customer>GetCustomers(string searchtext)
        //{
        //    AdventureWorksEntities dataContext = new AdventureWorksEntities();
        //    return dataContext.Customers.Take(100).ToList();
        //}

    }
}
