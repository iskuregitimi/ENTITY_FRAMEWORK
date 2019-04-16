using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class CredıtCartBLL
    {
        public static List<CreditCard> GetCrediCard()
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            return datacontext.CreditCards.ToList();

            
        }

    }
}
