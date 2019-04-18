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
        public static Person getPerson(int personId)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            Person personupdate = datacontext.People.Where(w => w.BusinessEntityID==personId).FirstOrDefault();
            return personupdate;

        }
        public static void addPerson(Person person)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            Person person2 = new Person();
            //person.PersonType = "EM";
            //    person.NameStyle = false;
            //    person.EmailPromotion = 0;
            //    person.rowguid = new Guid();
            //    person.ModifiedDate = DateTime.Now;
             person2 = dataContext.People.Where(w => w.BusinessEntityID == person.BusinessEntityID).FirstOrDefault();
            person2.FirstName = person.FirstName;
            person2.LastName = person.LastName;
            person2.MiddleName = person.MiddleName;


            //var pers = dataContext.People.Add(person);

            dataContext.SaveChanges();

            //return pers;
        }
    }
}
