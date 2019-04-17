using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class SiparisBLL
    {
        static AdventureWorksEntities dataContext = new AdventureWorksEntities();
        public static SalesOrderHeader AddOrder(int customerID,int salesPersonID,int territoryID,int billToAddressID, int shipToAddressID,int shipMethodID, int creditCardID,decimal subTotal,decimal Tax,decimal Freight,string Comment)
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
