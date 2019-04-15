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


    }
}
