using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
   public static class ProductBLL
    {
       static AdventureWorksEntities datacontext = new AdventureWorksEntities();
        //public static List<Product> GetProducts()
        //{

        //    return datacontext.Products.Where(x => x.ProductID > 700).ToList();
            
               
        //}

        public static object GetProducts()
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            var product = datacontext.Products.Where(x => x.ProductID > 700).Select(
                  x => new
                  {
                      x.ProductID,
                      x.Name,
                      x.ProductNumber,
                      x.StandardCost,

                      x.SafetyStockLevel,
                      x.ReorderPoint,
                  }
                  );

            return product.ToList();


        }

    }
}
