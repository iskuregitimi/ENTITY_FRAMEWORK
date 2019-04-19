using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class PersonBLL
    {
        static AdventureWorksEntities dataContext = new AdventureWorksEntities();
        public static Person getPerson(int personId)
        {
           
            Person personupdate = dataContext.People.Where(w => w.BusinessEntityID==personId).FirstOrDefault();
            return personupdate;

        }
        public static void addPerson(Person person)
        {
           
            //Person person2 = new Person();
          
            // person2 = dataContext.People.Where(w => w.BusinessEntityID == person.BusinessEntityID).FirstOrDefault();
            //person2.FirstName = person.FirstName;
            //person2.LastName = person.LastName;
            //person2.MiddleName = person.MiddleName;

            dataContext.SaveChanges();

         
        }

        public static void deletePerson(int BusinessEntityID)
        {
    
            Person persondelete = dataContext.People.Where(w => w.BusinessEntityID == BusinessEntityID).FirstOrDefault();
            
            dataContext.Employees.Remove(persondelete.Employee);
            //dataContext.SalesPersons.Remove(persondelete.SalesPerson);


            dataContext.People.Remove(persondelete);


            dataContext.SaveChanges();



            //var businessEntityAddresses = dataContext.BusinessEntityAddresses.Where(b => b.BusinessEntityID == customerId);
            //var addresList = dataContext.Addresses.Where(a => businessEntityAddresses.Any(b => b.AddressID == a.AddressID)).Select(
            //x => new
            //{
            //    x.AddressLine1,
            //    x.AddressID
            //}
            //);
            //return addresList.ToList();

        }
    }
}
