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
        public static List<SalesOrderHeader> GetOrders(int customerID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            return dataContext.SalesOrderHeaders.Where(x => x.CustomerID == customerID).ToList();

        }
    }
}
