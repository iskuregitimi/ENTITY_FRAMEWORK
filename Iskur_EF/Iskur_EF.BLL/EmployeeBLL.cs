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
        static AdventureWorksEntities dataContext = new AdventureWorksEntities();

        public static List<Employee> AllGetEmployees()
        {
            return dataContext.Employees.ToList();
        }

        public static List<Employee> GetEmployee(string searchText)
        {
            return dataContext.Employees.Where(x => x.JobTitle == searchText).ToList();
        }
        
        public static Employee Employee(int id)
        {
            return dataContext.Employees.FirstOrDefault(x => x.BusinessEntityID == id);
        }
    }
}
