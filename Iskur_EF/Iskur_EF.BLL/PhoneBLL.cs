using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class PhoneBLL
    {

        static AdventureWorksEntities dataContext = new AdventureWorksEntities();

        public static List<PersonPhone> GetPhones(int id)
        {
            return dataContext.PersonPhones.Where(x => x.BusinessEntityID == id).ToList();
        }
    }
}
