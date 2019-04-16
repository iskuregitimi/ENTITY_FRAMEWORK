using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
   public static  class ProductBLL
     {
    

        public static List<Product> GetProducts()
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Products.Where(x => x.ProductID>700).ToList();
        }


        public static Product GetProduct(int id)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Products.FirstOrDefault(x => x.ProductID == id);
        }

    }
}
