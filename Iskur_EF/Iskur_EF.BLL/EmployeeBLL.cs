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
        public static List<Employee>GetEmployees(string searchtext)
        {



            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.Employees.Take(100).ToList();

        }
        public static Employee GetBusinessEntity(int busiennesEntityId)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();



            return datacontex.Employees.Where(x=> x.BusinessEntityID==busiennesEntityId).FirstOrDefault();
        }
       

        public static List<Store> getStore()
        {

            AdventureWorksEntities datacontex = new AdventureWorksEntities();
            return datacontex.Stores.ToList();

        }
        public static List<SalesPerson> GetSalesPerson(int SalesPersonId)
        {

            AdventureWorksEntities datacontex = new AdventureWorksEntities();


            return datacontex.SalesPersons.Where(x => x.BusinessEntityID  == SalesPersonId).ToList();

        }
        public static object getCustomers(string searchText)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();
            var result = datacontex.Customers.Where(c => c.PersonID != null).Select(
                x => new
                {
                    x.CustomerID,
                    x.PersonID,
                    x.Person.FirstName,
                    x.Person.LastName,
                    x.TerritoryID

                }


                );
            return result.ToList();


        }
        public static List<SalesOrderHeader> getOrderHeader(int PersonId)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.SalesOrderHeaders.Where(x => x.CustomerID == PersonId).ToList();

        }
        public static List<SalesOrderDetail> getOrderdetail(int salesOrderId)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.SalesOrderDetails.Where(x => x.SalesOrderID== salesOrderId).ToList();

        }
        public static List<Product> GetProduct()
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.Products.ToList();

        }


        }
}
