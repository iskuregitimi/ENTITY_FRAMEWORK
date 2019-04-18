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
       static AdventureWorksEntities datacontext = new AdventureWorksEntities();
        public static List<SalesOrderHeader> GetSalesOrderHeaders(int id)
        {
            
            return datacontext.SalesOrderHeaders.Where(x => x.CustomerID == id).ToList();
        }

        public static List<SalesOrderDetail> GetOrderDetail(int SalesOrderId)
        {
           
            return datacontext.SalesOrderDetails.Where(x => x.SalesOrderID == SalesOrderId).ToList();
        }
        public static SalesOrderHeader AddOrder(SalesOrderHeader sales,DateTime Tarih)
        {
            
            SalesOrderHeader salesheader = new SalesOrderHeader();
            salesheader.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesheader.DueDate= Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesheader.CustomerID = sales.CustomerID;
            salesheader.TotalDue = sales.TotalDue;
            salesheader.ShipDate = Tarih;
            salesheader.BillToAddressID = sales.BillToAddressID;
            salesheader.ShipToAddressID = sales.ShipToAddressID;
            salesheader.ShipMethodID = sales.ShipMethodID;
            salesheader.TerritoryID = sales.TerritoryID;
            salesheader.CurrencyRateID = sales.CurrencyRateID;
            salesheader.CreditCardID = sales.CreditCardID;
            salesheader.SalesPersonID = sales.SalesPersonID;
            salesheader.SubTotal = sales.SubTotal;
            salesheader.TaxAmt = sales.TaxAmt;
            salesheader.Freight = sales.Freight;
            salesheader.Status = 5;
            salesheader.OnlineOrderFlag = false;
            salesheader.Comment = sales.Comment;
            salesheader.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesheader.rowguid = Guid.NewGuid();

            var header = datacontext.SalesOrderHeaders.Add(salesheader);
            datacontext.SaveChanges();
            return header;
        }

        public static void AddOrderDetail(Product Product,SalesOrderHeader salesheader)
        {
            SalesOrderDetail orderdetail = new SalesOrderDetail();
            orderdetail.SalesOrderID = salesheader.SalesOrderID;
            orderdetail.ProductID = Product.ProductID;
            orderdetail.SpecialOfferID = Product.SpecialOfferProducts.FirstOrDefault(x=>x.ProductID==Product.ProductID).SpecialOfferID;
            orderdetail.OrderQty = 1;
            orderdetail.UnitPrice = Product.StandardCost;
            orderdetail.rowguid = Guid.NewGuid();
           orderdetail.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            datacontext.SalesOrderDetails.Add(orderdetail);
            datacontext.SaveChanges();


        }
        
     
    }
}
