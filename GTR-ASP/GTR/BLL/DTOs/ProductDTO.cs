using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Code { get; set; }
        public int ProductBarcode { get; set; }
        public string Description { get; set; } = string.Empty;
        public string SizeName { get; set; } = string.Empty;
        public string ColorName { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public string VariantName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        public virtual CategoryDTO Category { get; set; }
        public virtual BrandDTO Brand { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
