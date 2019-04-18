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
        public static List<Employee> GetEmployees(string searchText)
        {
           
            return dataContext.Employees.Where(x=>x.Person.FirstName.Contains(searchText)||x.Person.LastName.Contains(searchText)).ToList();
            
         
        }
        public static Employee GetPeople(int BusinessEntityId)
        
        {
            AdventureWorksEntities efDataContext = new AdventureWorksEntities();
            Employee emp = efDataContext.Employees.Where(e => e.BusinessEntityID == BusinessEntityId).FirstOrDefault();
            return emp;
        }

        public static void UpdateEmployee(Employee emp)
        {
            Employee Personel = new Employee();
            Personel=  dataContext.Employees.Where(x => x.BusinessEntityID == emp.BusinessEntityID).FirstOrDefault();
            Personel.Person.FirstName = emp.Person.FirstName;
            Personel.Person.LastName = emp.Person.LastName;
            Personel.Person.MiddleName = emp.Person.MiddleName;
            Personel.JobTitle = emp.JobTitle;

            dataContext.SaveChanges();
         
            

        }
        
    }
}
