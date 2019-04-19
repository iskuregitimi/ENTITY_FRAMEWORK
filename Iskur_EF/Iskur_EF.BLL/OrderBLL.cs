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
     
       
        public static void DeleteOrder(int salesOrderId)
        {

            SalesOrderHeader orderdelete= dataContext.SalesOrderHeaders.Where(w => w.SalesOrderID== salesOrderId).FirstOrDefault();
            dataContext.SalesOrderDetails.Remove(orderdelete.SalesOrderDetails.FirstOrDefault());
            dataContext.SalesOrderHeaders.Remove(orderdelete);
            dataContext.SaveChanges();
        }
    }
}
