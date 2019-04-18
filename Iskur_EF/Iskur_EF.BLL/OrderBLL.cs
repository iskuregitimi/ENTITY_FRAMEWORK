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
        public static AdventureWorksEntities dataContext = new AdventureWorksEntities();

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

        public static SalesOrderHeader AddOrder(int customerID, int salesPersonID, int territoryID, int billToAddressID, int shipToAddressID, int shipMethodID, int creditCardID, decimal subTotal, decimal Tax, decimal Freight, string Comment)
        {
            SalesOrderHeader salesOrder = new SalesOrderHeader();
            salesOrder.RevisionNumber = 8;
            salesOrder.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.DueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.Status = 5;
            salesOrder.OnlineOrderFlag = false;
            salesOrder.CustomerID = customerID;
            salesOrder.SalesPersonID = salesPersonID;
            salesOrder.TerritoryID = territoryID;
            salesOrder.BillToAddressID = billToAddressID;
            salesOrder.ShipToAddressID = shipToAddressID;
            salesOrder.ShipMethodID = shipMethodID;
            salesOrder.CreditCardID = creditCardID;
            salesOrder.SubTotal = subTotal;
            salesOrder.TaxAmt = Tax;
            salesOrder.Freight = Freight;
            salesOrder.Comment = Comment;
            salesOrder.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.rowguid = Guid.NewGuid();

            var header = dataContext.SalesOrderHeaders.Add(salesOrder);
            dataContext.SaveChanges();
            return header;
        }

        public static void AddOrderDetails(Product products, SalesOrderHeader orderHeader)
        {
            SalesOrderDetail orderDetail = new SalesOrderDetail();
            orderDetail.SalesOrderID = orderHeader.SalesOrderID;
            orderDetail.ProductID = products.ProductID;
            orderDetail.SpecialOfferID = products.SpecialOfferProducts.FirstOrDefault(x => x.ProductID == products.ProductID).SpecialOfferID;
            orderDetail.OrderQty = 1;
            orderDetail.UnitPrice = products.ProductCostHistories.FirstOrDefault(x => x.ProductID == products.ProductID).StandardCost;
            orderDetail.UnitPriceDiscount = 0;
            orderDetail.rowguid = Guid.NewGuid();
            orderDetail.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));

            dataContext.SalesOrderDetails.Add(orderDetail);
            dataContext.SaveChanges();
        }
        public static Product GetProduct(int id)
        {
            return dataContext.Products.FirstOrDefault(x => x.ProductID == id);
        }
    }
}
