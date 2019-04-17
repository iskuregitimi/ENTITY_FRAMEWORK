using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
   public static class GetBLL
    {
        static AdventureWorksEntities dataContext = new AdventureWorksEntities();
        public static object GetSalesPerson()
        {
            var emp = dataContext.SalesPersons.OrderBy(x=>x.BusinessEntityID).Select(
                x => new
                {                   
                   FullName= x.Employee.Person.FirstName +" "+ x.Employee.Person.LastName,
                    x.BusinessEntityID                   
                }

                );
            return emp.ToList();

        }
        public static object GetCreditCard(int customerId)
        {
            var credi = dataContext.PersonCreditCards.Where(c=>c.BusinessEntityID==customerId).OrderBy(x => x.CreditCardID).Select(
                x => new
                {
                    x.CreditCardID
                }
                );
            return credi.ToList();
        }
        public static object GetCurrencyRateID()
        {

            var currencyrate = dataContext.CurrencyRates.Select(
                x => new
                {
                    x.CurrencyRateID,
                    x.Currency.CurrencyCode
                }
                );
            return currencyrate.ToList();
        }
        public static object GetTerritory(int customerid)
        {
            var territory = dataContext.Customers.Where(c=>c.CustomerID==customerid).OrderBy(x => x.TerritoryID).Select(
                x=> new
                {
                    x.TerritoryID,
                    
                }
                );
            return territory.ToList();
        }
        public static object GetBilltoAddress(int customerId)
        {
            var businessEntityAddresses = dataContext.BusinessEntityAddresses.Where(x => x.BusinessEntityID == customerId);
            var address = dataContext.Addresses.Where(c => businessEntityAddresses.Any(b => b.AddressID == c.AddressID)).Select(
                a=> new
                {
                    a.AddressLine1,
                    a.AddressID
                }
                );
            return address.ToList(); 
        }
        public static object GetShipMethod()
        {
            var shipmethod = dataContext.ShipMethods.OrderBy(x => x.ShipMethodID).Select(
                x => new
                {
                    x.ShipMethodID,
                    x.Name
                }
                );
            return shipmethod.ToList();
        }
        public static SalesOrderDetail GetSubTotal(int ProductId)
        {
            return dataContext.SalesOrderDetails.Where(c => c.ProductID == ProductId).FirstOrDefault();
          
        }


    }
}
