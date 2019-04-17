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
        public static object GetProduct()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = db.Products.Where(x => x.ProductID > 705).Select(x => new
            {
                x.ProductID,
                x.Name,
                x.StandardCost,
                x.ListPrice

            });
            return a.ToList();
        }

        public static object Get_SalePerson()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.People.Where(x => x.PersonType == "SP").Select(x => new { x.BusinessEntityID, SalesPersonName = x.FirstName + " " + x.MiddleName + " " + x.LastName }).ToList();

        }
        public static object GetCreditCardsID(int BEID)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = from pc in db.PersonCreditCards
                    join sc in db.CreditCards on pc.CreditCardID equals sc.CreditCardID
                    where pc.BusinessEntityID == BEID
                    select new
                    {
                        CardId = sc.CreditCardID,
                        CardNumber = sc.CardNumber
                    };


            return a.ToList();

        }
        public static object GetCurrencyRate()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = from p in db.Currencies
                    join kp in db.CurrencyRates on p.CurrencyCode equals kp.ToCurrencyCode
                    select new
                    {
                        CurrencyName = p.Name,
                        CurrencyID = kp.CurrencyRateID
                    };

            //var a = db.Currencies.Select(x => x.Name);
            return a.ToList();
        }
        public static List<SalesTerritory> GetTerritoryID()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.SalesTerritories.ToList();
        }
        public static object GetBillToAddressID(int customerId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            var businessEntityAddresses = dataContext.BusinessEntityAddresses.Where(b => b.BusinessEntityID == customerId);
            var addresList = dataContext.Addresses.Where(a => businessEntityAddresses.Any(b => b.AddressID == a.AddressID)).
            Select(x => new { AdressID = x.AddressID, AdressLine = x.AddressLine1 });

            return addresList.ToList();
        }
        public static List<ShipMethod> GetShipMetodID()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.ShipMethods.ToList();
        }
        public static int SaleOrderID { get; set; }
        public static decimal Total { get; set; }
        public static void İnsertOrderHeader(int _CustomerID, int _SalePersonID, int _TerratoryID, int _BillToAdressID, int _ShipedToAdressID, int _ShipedMethodID, int _CreditCardID, double ProductListPrice, int CurrencyRateID,string Comment)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
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
                Comment=Comment

            };
            db.SalesOrderHeaders.Add(orh);
            db.SaveChanges();
            SaleOrderID = db.SalesOrderHeaders.Max(x => x.SalesOrderID);
            Total = Convert.ToDecimal(orh.TotalDue);
        }
        public static void İnsertSaleOrderDetail(int _ProductID, decimal UnitPrice)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
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
