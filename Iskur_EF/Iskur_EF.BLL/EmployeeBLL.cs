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
        public static List<Employee>GetEmployees(string searchtext)
        {



            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.Employees.Take(100).ToList();

        }
        public static Employee GetBusinessEntity(int busiennesEntityId)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();



            return datacontex.Employees.Where(x=> x.BusinessEntityID==busiennesEntityId).FirstOrDefault();
        }
       

        public static List<Store> getStore()
        {

            AdventureWorksEntities datacontex = new AdventureWorksEntities();
            return datacontex.Stores.ToList();

        }
        public static List<SalesPerson> GetSalesPerson(int SalesPersonId)
        {

            AdventureWorksEntities datacontex = new AdventureWorksEntities();


            return datacontex.SalesPersons.Where(x => x.BusinessEntityID  == SalesPersonId).ToList();

        }
        public static object getCustomers(string searchText)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();
            var result = datacontex.Customers.Where(c => c.PersonID != null).Select(
                x => new
                {
                    x.CustomerID,
                    x.PersonID,
                    x.Person.FirstName,
                    x.Person.LastName,
                    x.TerritoryID

                }


                );
            return result.ToList();


        }
        public static List<SalesOrderHeader> getOrderHeader(int PersonId)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.SalesOrderHeaders.Where(x => x.CustomerID == PersonId).ToList();

        }
        public static List<SalesOrderDetail> getOrderdetail(int salesOrderId)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.SalesOrderDetails.Where(x => x.SalesOrderID== salesOrderId).ToList();

        }
        public static List<Product> GetProduct()
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.Products.Where(x=> x.ProductID>700).ToList();

        }
        public static Product  getProduct1(int id)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();
            return datacontex.Products.Where(x => x.ProductID== id).FirstOrDefault();


        }
        public static List<SalesOrderHeader> GetsalesOrder(int id)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();

            return datacontex.SalesOrderHeaders.Where(x => x.CustomerID == id).ToList();
        }

        public static SalesOrderHeader addProduct(int customerId)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();




            SalesOrderHeader header = new SalesOrderHeader();
         {
                header.RevisionNumber = 8;
                header.OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
                header.DueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
                header.Status = 5;
                header.OnlineOrderFlag = true;
                header.SalesOrderNumber = "SO43659";
                header.CustomerID = customerId;
                header.BillToAddressID = 985;
                header.ShipToAddressID = 985;
                header.ShipMethodID = 5;
                header.SubTotal = 20565;
                header.TaxAmt = 21565;
                header.Freight = 686;
                header.TotalDue = 42816;
                header.rowguid = Guid.NewGuid();
                header.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));


            }
            var salesheader = datacontex.SalesOrderHeaders.Add(header);
            datacontex.SaveChanges();
            return salesheader;
        }
        public static void addOrderDetail(SalesOrderHeader sales,Product product)
        {
            AdventureWorksEntities datacontex = new AdventureWorksEntities();
            SalesOrderDetail orderdetail = new SalesOrderDetail();
            {
                orderdetail.SalesOrderID = sales.SalesOrderID;
                //orderdetail.SalesOrderDetailID=sales.SalesOrde
                orderdetail.OrderQty = 1;
                orderdetail.ProductID = product.ProductID;
                orderdetail.SpecialOfferID = 1;
                orderdetail.UnitPrice = 20565;
                orderdetail.UnitPriceDiscount = 0;
                orderdetail.LineTotal = 20565;
                orderdetail.ModifiedDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            }

            datacontex.SalesOrderDetails.Add(orderdetail);
            datacontex.SaveChanges();


        }

        }
}
