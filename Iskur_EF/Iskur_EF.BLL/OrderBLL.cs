using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
   
    public static  class OrderBLL
    {
       static AdventureWorksEntities dataContext = new AdventureWorksEntities();

        public static object  GetBillToAdress(int customerId)
        {

            var bussinesEntityAdress = dataContext.BusinessEntityAddresses.Where(b => b.BusinessEntityID == customerId);
            var adresList = dataContext.Addresses.Where(a => bussinesEntityAdress.Any(b => b.AddressID == a.AddressID)).Select(b => new
            {
                b.AddressLine1

            });
            return adresList.ToList();


           
        }
        public static object GetSalePerson()
  
        {
            return dataContext.People.Where(x => x.PersonType == "SP").Select(x => new { x.BusinessEntityID, SalesPersonName = x.FirstName + " " + x.MiddleName + " " + x.LastName }).ToList();
           
        }
        public static object GetCrediCard(int CustomerId)
        {
            return dataContext.PersonCreditCards.Where(x=> x.BusinessEntityID==CustomerId).Select(
                x=>new
                {
                    x.CreditCardID
                }
                
                )
                .ToList();

        }

       public static object GetTerretory(int CustomerId)
        {
            return dataContext.Customers.Where(x => x.CustomerID == CustomerId).Select(
                x => new
                {
                    x.TerritoryID
                }

                ).ToList();
        }

        public static object GetShipToAddress(int CustomerId)
        {
            var bussinesEntityAdress = dataContext.BusinessEntityAddresses.Where(x => x.BusinessEntityID == CustomerId);
            var adresList = dataContext.Addresses.Where(y => bussinesEntityAdress.Any(x => x.AddressID == y.AddressID)).Select(b => new
            {
                b.AddressLine1
            }
            );
            return adresList.ToList();
        }
 
        public static object GetCurrentyRateId()
        {
            return dataContext.CurrencyRates.ToList();
        }



        public static object GetShipMetodId()
        {

            return dataContext.ShipMethods.ToList();
        }


        public static object GetProduct(string SearchText)
        {

            var product = dataContext.Products.Select(x => new

            {
                x.ProductID,
                x.Name,
                x.ProductDocument
              
            }
             );

            return product.ToList();

        }



        public static object getSubTotal()
        {

            return dataContext.Products.FirstOrDefault();
                
        }



    }
}
