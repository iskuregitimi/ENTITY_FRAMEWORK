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

        public static Person GetPerson(int id)
        {
            return dataContext.People.FirstOrDefault(x => x.BusinessEntityID == id);
        }
    }
}
