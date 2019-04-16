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
            AdventureWorksEntities datacontex = new AdventureWorksEntities();
            return datacontex.Products.ToList();
        }


     }
}
