using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
  public static class MagazaBLL
    {
        public static List<Store> GetStores(string searchText)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Stores.ToList();

        }
        public static Store GetStore(int SalesPersonId)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Stores.Where(x=>x.SalesPersonID==SalesPersonId).FirstOrDefault();

        }

        public static object GetProducts()
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            var result = datacontext.Products.Select(
                x => new
                {
                    x.Name,
                    x.Color,
                    x.ListPrice,
                    x.Size,
                    x.SizeUnitMeasureCode,
                    x.Weight,
                    x.WeightUnitMeasureCode
                }
                );

                return result.ToList();
        }

        public static object GetCurrencyRate()
        {
            AdventureWorksEntities crDataContext = new AdventureWorksEntities();
            return crDataContext.CurrencyRates
                .Select(x => new { x.CurrencyRateID, CurrencyCode = x.FromCurrencyCode + "=>" + x.ToCurrencyCode + "=" +x.AverageRate})
                .ToList();
        }

        public static object GetShippingMethod()
        {
            AdventureWorksEntities shipDataContext = new AdventureWorksEntities();
            return shipDataContext.ShipMethods.Select(x => new { x.ShipMethodID, ShipCompanies = x.Name }).ToList();
        }

        public static object CalculateListPriceWithCurrencyRate(string Name,int SelectedCurrencyID)
        {
            AdventureWorksEntities calcDataContext = new AdventureWorksEntities();
            var productprice = calcDataContext.Products.Where(x => x.Name == Name).Select(y=>
            
                y.ListPrice
            
            ).FirstOrDefault();
          
            var currencyRate = calcDataContext.CurrencyRates.Where(c => c.CurrencyRateID == SelectedCurrencyID).Select(cr =>
            
                cr.AverageRate
            
            ).FirstOrDefault();

            var calculatedprice = productprice * currencyRate;
            
            return calculatedprice.ToString();
        }

        public static float TaxAmount(float calculatedprice)
        {
            const float taxrate = 0.18F;
            float totaltaxamount = calculatedprice * taxrate;
            return totaltaxamount;
        }

        public static float freightrate(float calculatedprice)
        {
            const float freightrate = 0.1F;
            float freight = calculatedprice * freightrate;
            return freight;
        }

        //public static object getsalespersonid(int salespersonbei)
        //{
        //    AdventureWorksEntities gspDataContext = new AdventureWorksEntities();
        //    var findsalespersonid = gspDataContext.Stores.Where(x => x.BusinessEntityID == salespersonbei).Select(y=> y.SalesPersonID).FirstOrDefault();
        //    return findsalespersonid.ToString();
        //}

        public static SalesOrderHeader AddOrder(SalesOrderHeader sales)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            SalesOrderHeader salesOrder = new SalesOrderHeader();
            salesOrder.CustomerID = sales.CustomerID;
            salesOrder.OrderDate = DateTime.Now;// Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.DueDate = DateTime.Now;//  Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.ShipDate = sales.ShipDate;
            salesOrder.TotalDue = sales.TotalDue;
            salesOrder.SubTotal = sales.SubTotal;
            salesOrder.TerritoryID = sales.TerritoryID;
            salesOrder.TaxAmt = 100;
            salesOrder.Freight = 100;
            salesOrder.Comment = sales.Comment;
            salesOrder.CreditCardID = sales.CreditCardID;
            salesOrder.CreditCardApprovalCode = sales.CreditCardApprovalCode;
            salesOrder.SalesOrderID = sales.SalesOrderID;
            /* salesOrder.CurrencyRate = curencyId*/
            ;
            salesOrder.RevisionNumber = 8;
            salesOrder.Status = 5;
            salesOrder.OnlineOrderFlag = false;
            salesOrder.BillToAddressID = sales.BillToAddressID;
            salesOrder.ShipToAddressID = sales.ShipToAddressID;
            salesOrder.ShipMethodID = sales.ShipMethodID;
            salesOrder.ModifiedDate = DateTime.Now;//Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.rowguid = Guid.NewGuid();

            var header = dataContext.SalesOrderHeaders.Add(salesOrder);
            dataContext.SaveChanges();
            return header;
        }

        public static void AddOrderDetails(Product products, SalesOrderHeader orderHeader)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

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

        public static Product GETPRODUCT(int productId)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Products.Where(x => x.ProductID == productId).FirstOrDefault();
        }


    }
}
