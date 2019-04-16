using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskur_EF.DAL;

namespace Iskur_EF.BLL
{
    public class OrderDetailBLL



    {

        static AdventureWorksEntities dataContext = new AdventureWorksEntities();

        public static List<SalesOrderDetail> GetOrderDetails(int id)
        {
            return dataContext.SalesOrderDetails.Where(x => x.SalesOrderID == id).ToList();
        }

        public static void AddOrderDetails(Product product, SalesOrderHeader orderHeader)
        {
      
                SalesOrderDetail orderDetail = new SalesOrderDetail();
                orderDetail.SalesOrderID = orderHeader.SalesOrderID;
                orderDetail.ProductID = product.ProductID;
                orderDetail.SpecialOfferID = product.SpecialOfferProducts.FirstOrDefault(x => x.ProductID ==product.ProductID).SpecialOfferID;
                orderDetail.OrderQty = 1;
                orderDetail.UnitPrice = product.ProductCostHistories.FirstOrDefault(x => x.ProductID ==product.ProductID).StandardCost;
                orderDetail.UnitPriceDiscount = 0;
                orderDetail.rowguid = Guid.NewGuid();
                orderDetail.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));

                dataContext.SalesOrderDetails.Add(orderDetail);
                dataContext.SaveChanges();
            }


        }
    }
}
