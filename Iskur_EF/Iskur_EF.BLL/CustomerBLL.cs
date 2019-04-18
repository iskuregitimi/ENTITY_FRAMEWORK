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
        public static object GetCustomers(string searchText)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
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

        public static List<SalesOrderHeader> GetSalesOrderHeaders(int id)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.SalesOrderHeaders.Where(x => x.CustomerID== id).ToList();
        }

        public static List<SalesOrderDetail> GetOrderDetail(int SalesOrderId)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.SalesOrderDetails.Where(x => x.SalesOrderID == SalesOrderId).ToList();
        }

        public static SalesOrderHeader InsertSales(SalesOrderHeader sales)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.SalesOrderHeaders.Add(sales);
        }
        public static Customer GetCustomerId(int CustomerId)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            Customer cust = datacontext.Customers.Where(e => e.CustomerID == CustomerId).FirstOrDefault();
            return cust;
        }
        

        
    }
}
