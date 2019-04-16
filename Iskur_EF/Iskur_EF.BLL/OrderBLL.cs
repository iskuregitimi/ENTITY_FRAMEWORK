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
    }
}

