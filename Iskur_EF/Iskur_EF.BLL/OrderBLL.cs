using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class OrderBLL
    {
        public static object GetProduct()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = db.Products.Where(x => x.ProductID > 705).Select(x => new
            {
                x.ProductID,
                x.Name,
                x.StandardCost,
                x.ListPrice

            });
            return a.ToList();
        }

        public static List<Person> Get_SalePerson()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = db.People.Where(x => x.BusinessEntityID > 273 && x.BusinessEntityID <= 291);
            return a.ToList();
        }
        public static List<CreditCard> GetCreditCardsID()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = db.CreditCards;
            return a.ToList();
        }

    }
}
