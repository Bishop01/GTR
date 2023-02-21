using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<T>
    {
        public Task<List<T>> GetAll();
        public Task<T> Get(T p);
        public Task<bool> Add(T obj);
        public Task<bool> Update(T obj);
        public Task<bool> Remove(T obj);
    }
}
