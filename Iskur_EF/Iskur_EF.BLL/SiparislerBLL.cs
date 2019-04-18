using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class SiparislerBLL
    {

        static AdventureWorksEntities dataContext = new AdventureWorksEntities();
        public static SalesOrderHeader AddOrder(int customerID, int salePersonID, int territoryID, int billToAdressID, int shiptoadressID, int shipmethodID, int creditcardID, decimal subTotal, decimal tax, decimal freight, string comment)
        {
            SalesOrderHeader sales = new SalesOrderHeader();
            sales.CustomerID = customerID;
            sales.SalesPersonID = salePersonID;
            sales.TerritoryID = territoryID;
            sales.BillToAddressID = billToAdressID;
            sales.ShipToAddressID = shiptoadressID;
            sales.ShipMethodID = shipmethodID;
            sales.CreditCardID = creditcardID;
            sales.SubTotal = subTotal;
            sales.TaxAmt = tax;
            sales.Freight = freight;
            sales.Comment = comment;
            sales.RevisionNumber = 15;
            sales.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            sales.DueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            sales.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            sales.OnlineOrderFlag = false;
            sales.Status = 5;
            sales.rowguid = Guid.NewGuid();
            var header = dataContext.SalesOrderHeaders.Add(sales);
            dataContext.SaveChanges();
            return header;
        }

        public static void Orderdetail(Product product,SalesOrderHeader orderdetail)

        {
            SalesOrderDetail salesdetail = new SalesOrderDetail();
            salesdetail.SalesOrderID = orderdetail.SalesOrderID;
            salesdetail.ProductID = product.ProductID;
            salesdetail.OrderQty = 1;            

        }


        
       
      
        //public string CarrierTrackingNumber { get; set; }
        //public short OrderQty { get; set; }
        //public int ProductID { get; set; }
        //public int SpecialOfferID { get; set; }
        //public decimal UnitPrice { get; set; }
        //public decimal UnitPriceDiscount { get; set; }
        //public decimal LineTotal { get; set; }
        //public System.Guid rowguid { get; set; }
        //public System.DateTime ModifiedDate { get; set; }










    }
}
