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
        static AdventureWorksEntities dataContext = new AdventureWorksEntities();
        public static object GetTerrotry(int CustomerId)
        {
            return dataContext.Customers.Where(x => x.CustomerID == CustomerId).Select(
                x => new
                {
                    x.TerritoryID
                }

                ).ToList();
        }

        public static object GetCrediCard(int CustomerId)
        {
            return dataContext.PersonCreditCards.Where(x => x.BusinessEntityID == CustomerId).Select(


             x => new
             {
                 x.CreditCardID
             }

                ).ToList();
        }
        public static object GetCurrentyRateId()
        {
            return dataContext.CurrencyRates.ToList();
        }

        public static object GetSalePerson()

        {
            return dataContext.People.Where(x => x.PersonType == "SP").Select(
                x => new
                {
                    x.BusinessEntityID,

                    SalesPersonName = x.FirstName + " " + x.MiddleName + " " + x.LastName
                }).ToList();

        }


        public static object GetBillToAdress(int customerId)
        {

            var bussinesEntityAdress = dataContext.BusinessEntityAddresses.Where(b => b.BusinessEntityID == customerId);
            var adresList = dataContext.Addresses.Where(a => bussinesEntityAdress.Any(b => b.AddressID == a.AddressID)).Select(b => new
            {
                b.AddressLine1

            });
            return adresList.ToList();


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


        public static void AddOrder(int customerID, int salePersonID, int territoryID, int billToAdressID, int shiptoadressID, int shipmethodID, int creditcardID, decimal subTotal, decimal tax, decimal freight, string comment)
        {
     
   
            //SalesOrderHeader sales = new SalesOrderHeader();
            //sales.CustomerID = customerID;
            //sales.SalesPersonID = salePersonID;
            //sales.TerritoryID = territoryID;
            //sales.BillToAddressID = billToAdressID;
            //sales.ShipToAddressID = shiptoadressID;
            //sales.ShipMethodID = shipmethodID;
            //sales.CreditCardID = creditcardID;
            //sales.SubTotal = subTotal;
            //sales.TaxAmt = tax;
            //sales.Freight = freight;
            //sales.Comment = comment;
            //sales.RevisionNumber = 15;
            //sales.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            //sales.DueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            //sales.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            //sales.OnlineOrderFlag = false;
            //sales.Status = 5;
            //sales.rowguid = Guid.NewGuid();
            //var header = dataContext.SalesOrderHeaders.Add(sales);
            //dataContext.SaveChanges();

            //return header;



        }
    }
}
