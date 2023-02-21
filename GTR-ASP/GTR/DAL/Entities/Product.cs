using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Code { get; set; }
        public int ProductBarcode { get; set; }
        public string Description { get; set; } = string.Empty;
        public string SizeName { get; set; } = string.Empty;
        public string ColorName { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public string VariantName { get; set; } = string.Empty;

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual Category? Category { get; set; } = null;
        public virtual Brand? Brand { get; set; } = null;
        public virtual User? User { get; set; } = null;
    }
}
