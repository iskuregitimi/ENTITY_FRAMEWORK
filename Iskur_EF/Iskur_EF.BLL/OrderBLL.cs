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

        public static List<Person> Get_SalePerson()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.People.Where(x => x.BusinessEntityID > 273 && x.BusinessEntityID <= 291).ToList();

        }
        public static List<CreditCard> GetCreditCardsID()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.CreditCards.ToList();
        }
        public static List<CurrencyRate> GetCurrencyRate()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.CurrencyRates.ToList();

        }
        public static List<SalesTerritory> GetTerritoryID()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.SalesTerritories.ToList();
        }
        public static List<Address> GetBillToAdress()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.Addresses.ToList();
        }
        public static List<ShipMethod> GetShipMetodID()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            return db.ShipMethods.ToList();
        }
        public static int SaleOrderID { get; set; }
        public static void İnsertOrderHeader(int _CustomerID,int _SalePersonID,int _TerratoryID,int _BillToAdressID,int _ShipedToAdressID,int _ShipedMethodID,int _CreditCardID)
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
                SubTotal = 100,
                TaxAmt = Convert.ToDecimal(100 * 0.18),
                Freight = Convert.ToDecimal(100 * 0.1),
                TotalDue = Convert.ToDecimal(100 + 100 * 0.18 + 100 * 0.1),
                rowguid = Guid.NewGuid(),
                ModifiedDate=DateTime.Now
       
            };
            db.SalesOrderHeaders.Add(orh);
            db.SaveChanges();
            SaleOrderID = db.SalesOrderHeaders.Max(x => x.SalesOrderID);
        }
        public static void İnsertSaleOrderDetail(int _ProductID)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            SalesOrderDetail ord = new SalesOrderDetail
            {
                SalesOrderID = SaleOrderID,
                CarrierTrackingNumber = "4911 - 403C - 98",
                OrderQty = 1,
                ProductID = _ProductID,
                SpecialOfferID = 1,
                UnitPrice = 7000,
                UnitPriceDiscount = 0,
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now
            };
            db.SalesOrderDetails.Add(ord);
            db.SaveChanges();
        }

    }
}
