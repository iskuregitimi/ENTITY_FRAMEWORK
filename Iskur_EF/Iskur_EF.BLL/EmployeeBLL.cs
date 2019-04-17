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
            var adressList = dataContext.Addresses.Where(a => businessEntityAdresses.Any(b => b.AddressID == a.AddressID)).Select(b => new
            {
             b.AddressLine1
                
            
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
                    c.CreditCardID
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





    }
}


