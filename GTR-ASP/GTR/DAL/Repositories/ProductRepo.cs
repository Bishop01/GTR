using DAL.Entities;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    internal class ProductRepo : IProduct<Product>
    {
        private GTRDbContext DbContext { get; }
        public ProductRepo()
        {
            DbContext = new GTRDbContext();
        }

        public async Task<bool> Add(Product obj)
        {
            var result = await DbContext.Products.AddAsync(obj);
            return true;
        }

        public Task<Product> Get(Product p)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetAllCategories(User obj)
        {
            var user = await DbContext.Users.FirstOrDefaultAsync(x => x.Email.Equals(obj.Email));

            if (user == null)
                return null;

            return await DbContext.Categories.Include(x => x.Products).Where(x=>x.Products.Any(y=>y.UserId==user.Id)).ToListAsync();
        }

        public async Task<List<Product>> GetAll(User obj)
        {
            var user = await DbContext.Users.FirstOrDefaultAsync(x=>x.Email.Equals(obj.Email));

            if (user == null)
                return null;

            return await DbContext.Products.Include(c=>c.Category).Include(b=>b.Brand).Where(x=>x.UserId==user.Id).ToListAsync();
        }

        public Task<bool> Remove(Product obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
