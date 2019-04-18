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
        public static List<Product> GetProducts()
        {

            return datacontext.Products.Where(x => x.ProductID > 700).ToList();
            
               
        }

    }
}
