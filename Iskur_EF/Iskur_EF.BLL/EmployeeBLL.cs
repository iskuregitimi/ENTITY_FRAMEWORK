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
        public static List<Employee> GetEmployees(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Employees.Where(x=>x.Person.FirstName.Contains(searchText)||x.Person.LastName.Contains(searchText)).ToList();
        }
        public static Employee GetPeople(int BusinessEntityId)
        
        {
            AdventureWorksEntities efDataContext = new AdventureWorksEntities();
            Employee emp = efDataContext.Employees.Where(e => e.BusinessEntityID == BusinessEntityId).FirstOrDefault();
            return emp;
        }
    }
}
