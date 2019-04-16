using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
  public static  class ShipBLL
    {
        public static List<ShipMethod> GetShipMethods()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.ShipMethods.ToList();
        }
        public static List<PurchaseOrderHeader> GetPurchaseOrderHeaders()
        {

             AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.PurchaseOrderHeaders.ToList();
        }
    }
}
