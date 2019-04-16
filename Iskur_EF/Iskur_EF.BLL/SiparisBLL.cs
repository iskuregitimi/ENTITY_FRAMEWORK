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

        public static List<SalesOrderHeader> GetPurchaseOrders(int id)
        {
            return dataContext.SalesOrderHeaders.Where(x => x.CustomerID == id).ToList();
        }

        public static SalesOrderHeader AddOrder(int customerID, decimal totalDue)
        {
            SalesOrderHeader salesOrder = new SalesOrderHeader();
            salesOrder.CustomerID = customerID;
            salesOrder.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.DueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.TotalDue = totalDue;
            salesOrder.SubTotal = 100;
            salesOrder.TaxAmt = 100;
            salesOrder.Freight = 100;
            salesOrder.RevisionNumber = 8;
            salesOrder.Status = 5;
            salesOrder.OnlineOrderFlag = false;
            salesOrder.BillToAddressID = 25989;
            salesOrder.ShipToAddressID = 25989;
            salesOrder.ShipMethodID = 1;
            salesOrder.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.rowguid = Guid.NewGuid();

            var header = dataContext.SalesOrderHeaders.Add(salesOrder);
            dataContext.SaveChanges();
            return header;
        }

        public static List<SalesOrderDetail> GetOrderDetails(int id)
        {
            return dataContext.SalesOrderDetails.Where(x => x.SalesOrderID == id).ToList();
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
