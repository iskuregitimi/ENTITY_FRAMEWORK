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
        static AdventureWorksEntities datacontext = new AdventureWorksEntities();
        public static object GetCustomers(string searchText)
        {
            
            var result = datacontext.Customers.Where(c => c.PersonID != null).Select(
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

        public static List<SalesOrderHeader> GetSalesOrderHeaders(int id)
        {
            return datacontext.SalesOrderHeaders.Where(x => x.CustomerID== id).ToList();
        }

        public static List<SalesOrderDetail> GetOrderDetail(int SalesOrderId)
        {
            return datacontext.SalesOrderDetails.Where(x => x.SalesOrderID == SalesOrderId).ToList();
        }

        public static SalesOrderHeader InsertSales(SalesOrderHeader sales)
        {
            return datacontext.SalesOrderHeaders.Add(sales);
        }

        public static object GetPersonCreditCards(int id)
        {
            var result = datacontext.PersonCreditCards.Where(x => x.BusinessEntityID == id).Select(
                c => new
                {
                    c.CreditCard.CardNumber,
                }
                );
            return result.ToList();
        }

        public static object GetCurrencyRates()
        {
            var result = datacontext.Currencies.Select(
                x => new
                {
                    x.Name,
                });

            return result.ToList();
        }

        public static object  GetTerritories(int id)
        {
            var result = datacontext.Customers.Where(x => x.CustomerID == id).Select(
                c => new
                {
                    c.SalesTerritory.Name,
                }
                );
            return result.ToList();
        }

        public static object GetBillToAddressID(int customerId)
        {
            var businessEntityAddresses = datacontext.BusinessEntityAddresses.Where(b => b.BusinessEntityID == customerId);
            var addresList = datacontext.Addresses.Where(a => businessEntityAddresses.Any(b => b.AddressID == a.AddressID)).Select(
                x => new
                {
                    x.AddressLine1  
                }
                );

            return addresList.ToList();
        }

        public static object GetShipMethod()
        {
            var result = datacontext.ShipMethods.Select(
                x => new
                {
                    x.Name,
                });
            return result.ToList();
        }

        public static SalesOrderDetail GetProductPrice(int ProductID)
        {
            return datacontext.SalesOrderDetails.Where(x => x.ProductID == ProductID).FirstOrDefault();
        }
    }
}
