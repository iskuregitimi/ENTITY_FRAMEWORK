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
        public static object getCreditCart(int id)
        {
            AdventureWorksEntities datacontext = new AdventureWorksEntities();
            var result = datacontext.PersonCreditCards.Where(c => c.BusinessEntityID== id).Select(
                x => new
                {
                    x.CreditCard.CardNumber,
                    x.CreditCardID
                  
                }
                );

            return result.ToList();
        }
    }
}
