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
        
        public static List<Employee> GetEployees(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            return dataContext.Employees.Take(100).ToList(); ;
        }

        public static Employee GetEmployeeDetail(int BEID)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Employees.Where(x => x.BusinessEntityID == BEID).FirstOrDefault();
        }

        public static List<Store>GetStore(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();
            return dataContext.Stores.ToList();
        }
        public static List<Customer> Get_Customers()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = from b in db.Customers.Where(x=>x.PersonID!=null) select b;
            return a.ToList();
        }
        public static List<SalesOrderHeader> Get_Order( int CID)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = from b in db.SalesOrderHeaders.Where(x => x.CustomerID==CID) select b;
            return a.ToList();
        }
        public static List<SalesOrderDetail> Get_OrderDetail(int SPID)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = from b in db.SalesOrderDetails where b.SalesOrderID==SPID select b;
            return a.ToList();
        }
        public static List<Product> Get_Products()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            var a = from b in db.Products where b.ProductID>706 select b;
            return a.ToList();
        }
        public static int Create_Order(int prductId,int CustomerID)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            SalesOrderHeader ab = new SalesOrderHeader()
            {
                CustomerID = CustomerID,
                OrderDate = DateTime.Now,
                DueDate = DateTime.Now,
                Status = 5,
                OnlineOrderFlag = true,
                SalesPersonID = 276,
                BillToAddressID = 34,
                ShipToAddressID = 21,
                ShipMethodID = 1,
                SubTotal = 100,
                TaxAmt = 50,
                Freight = 100,
                ModifiedDate = DateTime.Now,
                rowguid = Guid.NewGuid()

            };
            
            db.SalesOrderHeaders.Add(ab);
           
            db.SaveChanges();
            SalesOrderId = db.SalesOrderHeaders.Max(x => x.SalesOrderID);
            return SalesOrderId;
            
        }
        public static int SalesOrderId { get; set; }
        public static void SalesOrderDetailİnsert(int ProdctId,int salesOrderId)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            SalesOrderDetail dt = new SalesOrderDetail()
            {
                ProductID = ProdctId,
                SalesOrderID = salesOrderId,
                OrderQty = 3,
                SpecialOfferID = 1,
                UnitPrice = 200,
                UnitPriceDiscount = 200,
                rowguid = Guid.NewGuid(),
                ModifiedDate=DateTime.Now

            };
  
            db.SalesOrderDetails.Add(dt);
            db.SaveChanges();
        }

    }
}
