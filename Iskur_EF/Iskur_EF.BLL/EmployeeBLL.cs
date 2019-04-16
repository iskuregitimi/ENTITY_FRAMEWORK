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
            return dataContext.Employees.Take(500).ToList();
        }

        public static Employee GetEmployee(int BusinessEntityID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Employees.
                Where(X => X.BusinessEntityID == BusinessEntityID).FirstOrDefault(); 
        }

        public static List <Store> GetStores(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Stores.ToList();
        }

        public static object GetCustomers(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.Customers.Where(c => c.PersonID != null).
                Select(
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

        public static object GetOrders(int CustomerID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.SalesOrderHeaders.
                Where(X => X.CustomerID == CustomerID).Select(
                    c => new
                    {
                        c.SalesOrderID,
                        c.OrderDate,
                        c.DueDate,
                        c.ShipDate,
                        c.CustomerID,
                        c.SalesPersonID,
                        c.SubTotal,
                        c.TaxAmt,
                        c.Freight,
                        c.TotalDue
                    }              
                );
            return result.ToList();
        }
    }
}
