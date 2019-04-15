﻿using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskur_EF.BLL
{
    public static class StoreBLL
    {
        public static List<Store> GetStores(string searchText)
        {
            AdventureWorksEntities dataContext = new AdventureWorksEntities();

            return dataContext.Stores.Where(x => x.Name.Contains(searchText)).ToList();

        }
    }
}
