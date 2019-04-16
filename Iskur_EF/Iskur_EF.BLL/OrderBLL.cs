using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class OrderBLL
    {
        public static object GetProducts()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result=dataContext.Products.Where(p=> p.ProductID>705).Select(
                x => new
                {
                    x.ProductID,
                    x.Name,
                    x.StandardCost,
                    x.ListPrice
                }
                );
            return result.ToList();
        }
        public static List<Person> GetSalesPerson()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.People.Where(p => p.BusinessEntityID > 273 && p.BusinessEntityID < 291);
            return result.ToList();

            //object metod ile
            //var result = dataContext.People.Where(p => p.BusinessEntityID > 273 && p.BusinessEntityID < 291).Select(
            //    x => new
            //    {
            //        x.FirstName
            //    }
            //    );
            //return result.ToArray();
        }
        public static List<CreditCard> GetCreditCardID()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.CreditCards;
            return result.ToList();
        }
        public static List<CurrencyRate> GetCurrencyRateID()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.CurrencyRates;
            return result.ToList();
        }
        public static List<SalesTerritory> GetSalesTerritoryID()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.SalesTerritories;
            return result.ToList();
        }
        //person.address deki addressid=billtoaddressıd ve addressid=shiptoadressid
        public static List<Address> GetBillToAddressID()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.Addresses;
            return result.ToList();
        }
        public static List<ShipMethod> GetShipMethodID()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.ShipMethods;
            return result.ToList();
        }
    }
}
