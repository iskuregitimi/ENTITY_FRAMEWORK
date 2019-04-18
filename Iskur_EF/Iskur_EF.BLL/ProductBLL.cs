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
       static AdventureWorksEntities datacontext = new AdventureWorksEntities();
        public static object GetProducts()
        {
           
            var products= datacontext.Products.Where(x=>x.ProductID > 700).Select(
                x=>new
                {
                    x.ProductID,
                    x.Name,
                    x.ProductNumber,
                    x.Color,
                    x.SafetyStockLevel,
                    x.Size,
                    x.ListPrice
                }
                
                );

            return products.ToList();

        }

        public static Product GetProduct(int productid)
        {
            return datacontext.Products.Where(x => x.ProductID == productid).FirstOrDefault();
        }
    }
}
