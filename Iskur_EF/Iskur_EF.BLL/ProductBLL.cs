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
        public static List<Product> GetProductsInformation(string searchText)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Products.ToList();
        }

    }
}
