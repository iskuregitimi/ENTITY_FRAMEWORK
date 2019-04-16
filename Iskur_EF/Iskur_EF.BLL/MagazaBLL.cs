using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
  public static class MagazaBLL
    {
        public static List<Store> GetStores(string searchText)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Stores.ToList();

        }
        public static Store GetStore(int SalesPersonId)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Stores.Where(x=>x.SalesPersonID==SalesPersonId).FirstOrDefault();

        }



  
    }
}
