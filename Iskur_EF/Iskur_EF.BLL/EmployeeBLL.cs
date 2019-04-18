using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class EmployeeBLL
    {
        public static List<Employee> GetEmployees(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Employees.Where(x => x.Person.FirstName.Contains(searchText) || x.Person.LastName.Contains(searchText)).ToList();

        }
        public static Employee GetPeople(int BusinessEntityId)

        {
            AdventureWorksEntities efDataContext = new AdventureWorksEntities();
            Employee emp = efDataContext.Employees.Where(e => e.BusinessEntityID == BusinessEntityId).FirstOrDefault();
            return emp;
        }
        public static object GetBillToAdressID(int CustomerId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var businessEntityAdresses = dataContext.BusinessEntityAddresses.Where(b => b.BusinessEntityID ==CustomerId);
            var adressList = dataContext.Addresses.Where(a => businessEntityAdresses.Any(b => b.AddressID == a.AddressID)).Select(x => new
            {
               x.AddressID,
                x.AddressLine1,
                
            
            }


            );
            return adressList.ToList();
        }
        public static object GetCreditCard (int CustomerId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            var CreditCard = dataContext.PersonCreditCards.Where(b => b.BusinessEntityID == CustomerId).Select(
                c => new
                {
                    c.CreditCardID,
                    c.CreditCard.CardNumber,
                }


            );
            return CreditCard.ToList();
                       
        }

        public static object CurrencyRate()
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.CurrencyRates.Select(x => new
            {
                x.CurrencyRateID,
                Toplam = x.FromCurrencyCode + "-" + x.ToCurrencyCode + " " + x.AverageRate
            }).ToList();
            
        }
        public static object GetShipMethodName()
         {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.ShipMethods.Select(
              x => new
              {
                  x.ShipMethodID,
                  x.Name,
              });
            return result.ToList();
        }

        public static object GetTerritories(int CustomerId)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            var result = dataContext.Customers.Where(x => x.CustomerID == CustomerId).Select(
                c => new
                {
                    c.TerritoryID,
                    c.SalesTerritory.Name,
                }
                );
            return result.ToList();

        }
        public static Product GetProuctID(int ProductID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Products.Where(x => x.ProductID == ProductID).FirstOrDefault();

        }
        




    }
}


