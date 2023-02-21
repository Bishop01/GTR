using AutoMapper;
using BLL.DTOs;
using DAL.Entities;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helper
{
    public class Mapper<T1, T2>
    {
        public static List<T2> MapList(List<T1> obj2)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T1, T2>());
            var mapper = new Mapper(config);

            List<T2> dto = mapper.Map<List<T2>>(obj2);

            return dto;
        }
        public static List<T2> MapListAll(List<T1> obj2)
        {
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Product, ProductDTO>();
                    cfg.CreateMap<ProductDTO, Product>();
                    cfg.CreateMap<User, UserDTO>();
                    cfg.CreateMap<UserDTO, User>();
                    cfg.CreateMap<Category, CategoryDTO>();
                    cfg.CreateMap<CategoryDTO, Category>();
                    cfg.CreateMap<Brand, BrandDTO>();
                    cfg.CreateMap<BrandDTO, Brand>();
                });
            var mapper = new Mapper(config);

            List<T2> dto = mapper.Map<List<T2>>(obj2);

            return dto;
        }

        public static T2 Map(T1 obj2)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T1, T2>());
            var mapper = new Mapper(config);

            T2 dto = mapper.Map<T2>(obj2);

            return dto;
        }
        public static T2 MapAll(T1 obj2)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<ProductDTO, Product>();
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<CategoryDTO, Category>();
                cfg.CreateMap<Brand, BrandDTO>();
                cfg.CreateMap<BrandDTO, Brand>();
            });
            var mapper = new Mapper(config);

            T2 dto = mapper.Map<T2>(obj2);

            return dto;
        }
    }
}
