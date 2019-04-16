using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
  public  class ProductBLL
    {


        public static List<Product> GetProducts(int productID)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Products.ToList();

          
        }


    }
}
