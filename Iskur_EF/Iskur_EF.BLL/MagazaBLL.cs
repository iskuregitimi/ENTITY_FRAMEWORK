using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
  public static class MagazaBLL
    {
        public static List<Store> GetStores(string searchText)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Stores.ToList();

        }
        public static Store GetStore(int SalesPersonId)
        {

            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.Stores.Where(x=>x.SalesPersonID==SalesPersonId).FirstOrDefault();

        }

        public static object GetProducts()
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            var result = datacontext.Products.Select(
                x => new
                {
                    x.Name,
                    x.Color,
                    x.ListPrice,
                    x.Size,
                    x.SizeUnitMeasureCode,
                    x.Weight,
                    x.WeightUnitMeasureCode
                }
                );

                return result.ToList();
        }

        public static object GetCurrencyRate()
        {
            AdventureWorksEntities crDataContext = new AdventureWorksEntities();
            return crDataContext.CurrencyRates
                .Select(x => new { x.CurrencyRateID, CurrencyCode = x.FromCurrencyCode + "=>" + x.ToCurrencyCode + "=" +x.AverageRate})
                .ToList();
        }

        public static object GetShippingMethod()
        {
            AdventureWorksEntities shipDataContext = new AdventureWorksEntities();
            return shipDataContext.ShipMethods.Select(x => new { x.ShipMethodID, ShipCompanies = x.Name }).ToList();
        }
    }
}
