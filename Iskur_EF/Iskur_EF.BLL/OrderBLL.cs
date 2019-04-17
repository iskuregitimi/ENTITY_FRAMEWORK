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
        public static object GetSalesPerson()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.People.Where(p => p.PersonType=="SP").Select(x=> new { x.BusinessEntityID, SalesPersonName = x.FirstName + " " + x.MiddleName + " " + x.LastName }).ToList();
            //object metod ile
            //var result = dataContext.People.Where(p => p.BusinessEntityID > 273 && p.BusinessEntityID < 291).Select(
            //    x => new
            //    {
            //        x.FirstName
            //    }
            //    );
            //return result.ToArray();
        }
        public static object GetCreditCardID(int CustomerID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.PersonCreditCards.Where(b => b.BusinessEntityID == CustomerID);
            var kredikartlist = dataContext.CreditCards.Where(a => result.Any(b => b.CreditCardID == a.CreditCardID)).Select(x=> new { x.CreditCardID, KrediKartıListesi=x.CardNumber});
            return kredikartlist.ToList();
        }
        public static object GetCurrencyRateID()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var currencylist = dataContext.CurrencyRates.Select(x => new { x.CurrencyRateID, DövizKuruListesi=x.ToCurrencyCode});
            return currencylist.ToList();
        }
        public static List<SalesTerritory> GetSalesTerritoryID()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.SalesTerritories;
            return result.ToList();
        }
        //person.address deki addressid=billtoaddressıd ve addressid=shiptoadressid
        public static object GetBillToAddressID(int CustomerID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var businessEntityAddresses = dataContext.BusinessEntityAddresses.Where(b => b.BusinessEntityID == CustomerID);
            var addresList = dataContext.Addresses.Where(a => businessEntityAddresses.Any(b => b.AddressID == a.AddressID)).Select(x => new { x.AddressID, ShipAdres = x.AddressLine1 + " " + x.AddressLine2 });
            return addresList.ToList(); 
        }
        public static List<ShipMethod> GetShipMethodID()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.ShipMethods;
            return result.ToList();
        }
    }
}
