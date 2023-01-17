using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Subcategory
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public Category Category { get; set; }
    }
}
