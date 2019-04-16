using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class StoreBLL
    {

        static AdventureWorksEntities dataContext = new AdventureWorksEntities();

        public static List<Store> GetStores()
        {
            return dataContext.Stores.ToList();
        }

        public static List<Store> GetStores(string searchText)
        {
            return dataContext.Stores.Where(x=>x.Name == searchText).ToList();
        }

        public static List<Store> GetPerson(int id)
        {
            return dataContext.Stores.Where(x=>x.SalesPersonID==id).ToList();
        }
    }
}
