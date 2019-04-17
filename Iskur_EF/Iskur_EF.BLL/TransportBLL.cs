using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public class TransportBLL
    {
        public static List<ShipMethod> GetShipmetod()
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.ShipMethods.ToList();
        }

    }
}
