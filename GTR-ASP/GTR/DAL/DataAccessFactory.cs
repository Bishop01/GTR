using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IAuth AuthDataAccess()
        {
            return new AuthRepo();
        }

        public static IProduct<Product> ProductDataAccess()
        {
            return new ProductRepo();
        }
    }
}
