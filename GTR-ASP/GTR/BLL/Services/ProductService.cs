using BLL.DTOs;
using BLL.Helper;
using DAL;
using DAL.Entities;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService
    {
        public static async Task<List<ProductDTO>> GetProducts(UserDTO user)
        {
            User newUser = new User() { Email = user.Email };
            List<Product> products = await DataAccessFactory.ProductDataAccess().GetAll(newUser);

            List<ProductDTO> mappedProducts = new List<ProductDTO>();
            foreach(var product in products)
            {
                var p = new ProductDTO()
                {
                    Id = product.Id,
                    Code = product.Code,
                    Name = product.Name,
                    ColorName = product.ColorName,
                    Description = product.Description,
                    ModelName = product.ModelName,
                    ProductBarcode = product.ProductBarcode,
                    VariantName = product.VariantName,
                    SizeName = product.SizeName
                };

                if(product.Brand != null)
                {
                    p.Brand = new BrandDTO()
                    {
                        Id = product.Brand.Id,
                        Country = product.Brand.Country,
                        Name = product.Brand.Name
                    };
                }
                if(product.Category != null)
                {
                    p.Category = new CategoryDTO()
                    {
                        Id = product.Category.Id,
                        Name = product.Category.Name,
                    };
                }

                mappedProducts.Add(p);
            }

            return mappedProducts;
        }

        public static async Task<List<CategoryDTO>> GetCategories(UserDTO user)
        {
            User newUser = new User() { Email = user.Email };
            List<Category> categories = await DataAccessFactory.ProductDataAccess().GetAllCategories(newUser);

            List<CategoryDTO> mappedCategories = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                List<ProductDTO> products = new List<ProductDTO>();
                var p = new CategoryDTO()
                {
                    Id=category.Id,
                    Name=category.Name,
                };
                foreach(var product in category.Products)
                {
                    ProductDTO pr = new ProductDTO()
                    {
                        Code = product.Code,
                        ColorName = product.ColorName,
                        Description = product.Description,
                        ModelName = product.ModelName,
                        Name = product.Name,
                        ProductBarcode = product.ProductBarcode,
                        Id = product.Id,
                        VariantName = product.VariantName,
                        SizeName = product.SizeName
                    };
                    if(pr.Brand!=null)
                    {
                        pr.Brand = new BrandDTO()
                        {
                            Id = pr.Brand.Id,
                            Country = pr.Brand.Country,
                            Name = pr.Brand.Name
                        };
                    }
                    products.Add(pr);
                }
                p.Products = products;
                mappedCategories.Add(p);
            }

            return mappedCategories;
        }


        public static async Task<bool> AddProduct(ProductDTO obj)
        {
            Product product = new Product()
            {
                Code = obj.Code,
                ColorName = obj.ColorName,
                Description = obj.Description,
                ModelName = obj.ModelName,
                Name = obj.Name,
                ProductBarcode = obj.ProductBarcode,
                VariantName = obj.VariantName,
                SizeName = obj.SizeName,
                UserId=obj.UserId,
                CategoryId=obj.CategoryId,
                BrandId=1
            };

            return await DataAccessFactory.ProductDataAccess().Add(product);
        }
    }

}
