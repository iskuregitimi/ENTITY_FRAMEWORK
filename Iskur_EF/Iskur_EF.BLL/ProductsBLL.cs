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
                    x.Color
                    

                }
                );

            return result.ToList();


        }

        public static object getCurrenny()
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Currencies.ToList();

        }

        public static object Linetotal(int productId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            //return datacontext.SalesOrderDetails.ToList();

            var ProductID = dataContext.Products.Where(b => b.ProductID== productId);
            var lineTotal = dataContext.SalesOrderDetails.Where(a => ProductID.Any(b => b.ProductID == a.ProductID)).Select(
            x => new
            {
                x.LineTotal
            }
            );
            return lineTotal.ToList();

        }



    }
}
