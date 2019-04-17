using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class SalesBLL
    {
      
        public static object GetSalesPeople()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.SalesPersons.Select(
                x => new
                {
                    x.Employee.Person.FirstName,
                    x.Employee.Person.LastName
                }
                );

            return result.ToList(); 
        }
        public static void addToComment()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            //dataContext
        }

        public static List<SalesTerritory> GetTerritories(int Teritoriesid)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            return dataContext.SalesTerritories.Where(x => x.TerritoryID == Teritoriesid).ToList();

        }

       // ------------------------------------------------------------------------------------------------------------

        public static List<SalesOrderHeader> GetPurchaseOrders(int id)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            return dataContext.SalesOrderHeaders.Where(x => x.CustomerID == id).ToList();
        }

        public static SalesOrderHeader AddOrder(int customerID, decimal totalDue,decimal subtotal,int biltoAdressId,int salesAddressId,int shipmetodId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            SalesOrderHeader salesOrder = new SalesOrderHeader();
            salesOrder.CustomerID = customerID;
            salesOrder.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.DueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.TotalDue = totalDue;
            salesOrder.SubTotal = subtotal;
            salesOrder.TaxAmt = 100;
            salesOrder.Freight = 100;
            salesOrder.RevisionNumber = 8;
            salesOrder.Status = 5;
            salesOrder.OnlineOrderFlag = false;
            salesOrder.BillToAddressID = biltoAdressId;
            salesOrder.ShipToAddressID = salesAddressId;
            salesOrder.ShipMethodID = shipmetodId;
            salesOrder.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            salesOrder.rowguid = Guid.NewGuid();

            var header = dataContext.SalesOrderHeaders.Add(salesOrder);
            dataContext.SaveChanges();
            return header;
        }


        public static List<SalesOrderDetail> GetOrderDetails(int id)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            return dataContext.SalesOrderDetails.Where(x => x.SalesOrderID == id).ToList();
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


    }
}
