using DAL.Entities;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProduct<T>: IRepo<T>
    {
        public Task<List<T>> GetAll(User user);
        public Task<List<Category>> GetAllCategories(User user);
    }
}
