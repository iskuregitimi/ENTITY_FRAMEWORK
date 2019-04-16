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
        public static  object  getProduct(string searchText)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();





            var result = datacontext.Products.Select(
                x => new
                {
                    x.Name,
                    x.ProductNumber,
                    x.SafetyStockLevel,
                    x.Color
                   
                }
                );

            return result.ToList();
        

    }
    } }
