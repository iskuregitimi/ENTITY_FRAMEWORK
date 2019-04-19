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
        public static object GetShip()
        {
            return dataContext.ShipMethods.ToList();
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
                b.AddressLine1,
                b.AddressID

            });
            return adresList.ToList();


        }
        public static object GetShipToAddress(int CustomerId)
        {
            var bussinesEntityAdress = dataContext.BusinessEntityAddresses.Where(x => x.BusinessEntityID == CustomerId);
            var adresList = dataContext.Addresses.Where(y => bussinesEntityAdress.Any(x => x.AddressID == y.AddressID)).Select(b => new
            {
                b.AddressLine1,
                b.AddressID
            }
            );
            return adresList.ToList();
        }


        public static SalesOrderHeader AddOrder(SalesOrderHeader salesheader)
        {
            SalesOrderHeader sales = new SalesOrderHeader();
            sales.CustomerID = salesheader.CustomerID;
            sales.SalesPersonID = salesheader.SalesPersonID;
            sales.TerritoryID = salesheader.TerritoryID;
            sales.BillToAddressID = salesheader.BillToAddressID;
            sales.ShipToAddressID = salesheader.ShipToAddressID;
            sales.ShipMethodID = salesheader.ShipMethodID;
            sales.CreditCardID = salesheader.CreditCardID;
            sales.SubTotal = salesheader.SubTotal;
            sales.TaxAmt = salesheader.TaxAmt;
            sales.Freight = salesheader.Freight;
            sales.Comment = salesheader.Comment;
            sales.RevisionNumber = 15;
            sales.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            sales.DueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            sales.ShipDate = salesheader.ShipDate;
            sales.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            sales.OnlineOrderFlag = false;
            sales.Status = 5;
            sales.rowguid = Guid.NewGuid();

            var header = dataContext.SalesOrderHeaders.Add(sales);
            dataContext.SaveChanges();
            return header;
        }

    }
}
