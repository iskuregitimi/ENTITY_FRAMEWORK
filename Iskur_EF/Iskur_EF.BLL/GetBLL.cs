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
            var emp = dataContext.Employees.Where(x => x.JobTitle == "Sales Representative").Select(
                x => new
                {                   
                   FullName= x.Person.FirstName +" "+ x.Person.LastName,
                    x.BusinessEntityID                   
                }

                );
            return emp.ToList();

        }
        public static object GetCreditCard()
        {

            var credi = dataContext.CreditCards.OrderBy(x => x.CreditCardID).Select(
                x => new
                {
                    x.CreditCardID
                }
                );
            return credi.ToList();
        }
        public static object GetCurrencyRateID()
        {

            var currencyrate = dataContext.CurrencyRates.OrderBy(x => x.CurrencyRateID).Select(
                x => new
                {
                    x.CurrencyRateID,
                }
                );
            return currencyrate.ToList();
        }
        public static object GetTerritory()
        {
            var territory = dataContext.SalesTerritories.OrderBy(x => x.TerritoryID).Select(
                x=> new
                {
                    x.TerritoryID,
                }
                );
            return territory.ToList();
        }
        public static object GetShipMethod()
        {
            var shipmethod = dataContext.ShipMethods.OrderBy(x => x.ShipMethodID).Select(
                x => new
                {
                    x.ShipMethodID
                }
                );
            return shipmethod.ToList();
        }
    }
}
