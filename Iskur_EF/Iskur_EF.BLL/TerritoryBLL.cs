using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class TerritoryBLL
    {
        static AdventureWorksEntities datacontext = new AdventureWorksEntities();

        public static List<SalesTerritory> GetSalesTerritory()
        {
            return datacontext.SalesTerritories.ToList();
        }
    }
}
