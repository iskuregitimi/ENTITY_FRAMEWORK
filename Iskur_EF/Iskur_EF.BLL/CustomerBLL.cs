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
                    x.PersonID,
                    x.TerritoryID
                }
                );

            return result.ToList();
        }
        public static Customer GetCustomerName(int id)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Customers.Where(c => c.CustomerID == id).FirstOrDefault();
           
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

        //public static SalesTerritory getSalesTeritory(int id)
        //{
        //    AdventureWorksEntities datacontext = new AdventureWorksEntities();
        //    return datacontext.SalesTerritories.Where(x=> x.c)


        //}

        public static object getSalesTEritory(int id)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            var result = datacontext.Customers.Where(c => c.CustomerID== id).Select(
                x => new
                {
                    x.SalesTerritory.Name
                }
                );

            return result.ToList();
        }

        public static object GetBillToAddressID(int customerId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            var businessEntityAddresses = dataContext.BusinessEntityAddresses.Where(b => b.BusinessEntityID == customerId);
            var addresList = dataContext.Addresses.Where(a => businessEntityAddresses.Any(b => b.AddressID == a.AddressID)).Select(
            x => new
            {
                x.AddressLine1
            }
            );
            return addresList.ToList();
        }
        public static object GetShipTOAdress(int customerId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            var businessEntityAddresses = dataContext.BusinessEntityAddresses.Where(b => b.BusinessEntityID == customerId);
            var addresList = dataContext.Addresses.Where(a => businessEntityAddresses.Any(b => b.AddressID == a.AddressID)).Select(
            x => new
            {
                x.AddressLine1
            }
            );
            return addresList.ToList();
        }

    }
}
