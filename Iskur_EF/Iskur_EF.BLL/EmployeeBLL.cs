using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
   public static class EmployeeBLL
    {

        public static  List<Employee> GetEmployees(string searchText)
        {

            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Employees.Where(x => x.Person.FirstName.Contains(searchText)
            || x.Person.LastName.Contains(searchText)
            || x.Person.MiddleName.Contains(searchText)).ToList();
        }

        public static Employee GetEmployee(int BusinessEntityID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Employees.Where(x => x.BusinessEntityID == BusinessEntityID).FirstOrDefault();

        }

        public static  List<Store> GetStores(string SearchText)
        {

            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Stores.ToList();
        }

        public static Store GetStore(int SalesPersonID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Stores.Where(x => x.SalesPersonID== SalesPersonID).FirstOrDefault();
        }







    }
}
