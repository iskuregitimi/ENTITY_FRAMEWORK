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
        public static SalesOrderHeader AddOrder(int CustomerId,decimal totaldue)
        {
            
            SalesOrderHeader salesheader = new SalesOrderHeader();
            salesheader.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesheader.DueDate= Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesheader.CustomerID = CustomerId;
            salesheader.TotalDue = totaldue;
            salesheader.BillToAddressID = 25989;
            salesheader.ShipToAddressID = 25989;
            salesheader.ShipMethodID = 1;
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
