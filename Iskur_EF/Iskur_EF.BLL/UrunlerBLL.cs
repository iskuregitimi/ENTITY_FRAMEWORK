using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class UrunlerBLL
    {
        public static List<Product> GetProducts(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Products.ToList();
        }
    }
}