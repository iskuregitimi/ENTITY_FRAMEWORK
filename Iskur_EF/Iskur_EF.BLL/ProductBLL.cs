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
        public static object GetProducts(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.Products.Where(x => x.ProductID > 700).Select(
                x => new
                {
                    x.ProductID,
                    x.Name,
                    x.ProductNumber,
                    x.Color,
                    x.SafetyStockLevel,
                    x.StandardCost,
                    x.ListPrice,
                    x.Size,
                    x.Weight,
                    x.SellStartDate,
                    x.SellEndDate
                }
                );
            return result.ToList();
        }
    }
}
