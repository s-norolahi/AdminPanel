using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dto
{
    public class CategoryPageDTO
    {
        public Category Category { get; set; }
        public ICollection<Subcategory> Subcategories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
