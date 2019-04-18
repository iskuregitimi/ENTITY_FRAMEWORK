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
        public static AdventureWorksEntities db = new AdventureWorksEntities();

        public static int SaleOrderID { get; set; }
        public static decimal Total { get; set; }

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
            var result = dataContext.CurrencyRates.Select(x => new { x.CurrencyRateID, DövizKuruListesi = x.FromCurrencyCode + " to " + x.ToCurrencyCode + " with " + x.AverageRate });
            return result.ToList();
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

        public static void İnsertOrderHeader(int _CustomerID, int _SalePersonID, int _TerratoryID, int _BillToAdressID, int _ShipedToAdressID, int _ShipedMethodID, int _CreditCardID, double ProductListPrice, int CurrencyRateID, string Comment)
        {

            SalesOrderHeader orh = new SalesOrderHeader
            {
                CustomerID = _CustomerID,
                RevisionNumber = 8,
                OrderDate = DateTime.Now,
                DueDate = DateTime.Now,
                Status = 5,
                OnlineOrderFlag = false,
                SalesPersonID = _SalePersonID,
                TerritoryID = _TerratoryID,
                BillToAddressID = _BillToAdressID,
                ShipToAddressID = _ShipedToAdressID,
                ShipMethodID = _ShipedMethodID,
                CreditCardID = _CreditCardID,
                TaxAmt = Convert.ToDecimal(ProductListPrice * 0.18),
                Freight = Convert.ToDecimal(ProductListPrice * 0.1),
                TotalDue = Convert.ToDecimal(ProductListPrice + ProductListPrice * 0.18 + ProductListPrice * 0.1),
                SubTotal = Convert.ToDecimal(ProductListPrice),
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now,
                CurrencyRateID = CurrencyRateID,
                Comment = Comment

            };
            db.SalesOrderHeaders.Add(orh);
            db.SaveChanges();
            SaleOrderID = db.SalesOrderHeaders.Max(x => x.SalesOrderID);
            Total = Convert.ToDecimal(orh.TotalDue);
        }

        public static void İnsertSaleOrderDetail(int _ProductID, decimal UnitPrice)
        {

            SalesOrderDetail ord = new SalesOrderDetail
            {
                SalesOrderID = SaleOrderID,
                CarrierTrackingNumber = "4911 - 403C - 98",
                OrderQty = 1,
                ProductID = _ProductID,
                SpecialOfferID = 1,
                UnitPrice = UnitPrice,
                UnitPriceDiscount = 0,
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now
            };
            db.SalesOrderDetails.Add(ord);
            db.SaveChanges();
        }
    }
}
