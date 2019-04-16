using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{

    public static class OrderDetaisBLL
    {
        static AdventureWorksEntities dataContext = new AdventureWorksEntities();

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
    }

}
