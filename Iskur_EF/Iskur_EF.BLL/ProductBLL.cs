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

        static AdventureWorksEntities dataContext = new AdventureWorksEntities();

        public static List<Product> GetProducts()
        {
            return dataContext.Products.Where(x=>x.ProductID >=700).ToList();
        }

        public static Product GetProduct(int id)
        {
            return dataContext.Products.FirstOrDefault(x => x.ProductID == id);
        }
    }
}
