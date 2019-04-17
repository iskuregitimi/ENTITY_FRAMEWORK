using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class ProductsBLL
    {
        public static object getProduct(string searchText)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();





            var result = datacontext.Products.Select(
                x => new
                {
                    x.ProductID,
                    x.Name,
                    x.ProductNumber,
                    x.SafetyStockLevel,
                    x.Color,
                    x.StandardCost,
                    x.ListPrice,

                    

                }
                );

            return result.ToList();


        }

        public static object getCurrenny()
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Currencies.ToList();

        }

        public static SalesOrderDetail Linetotal(int productId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.SalesOrderDetails.Where(x => x.ProductID == productId).FirstOrDefault();


        }



    }
}
