using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product : BaseEntity
    {

        [StringLenght(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, 1000)]
        public Decimal Price { get; set; }

        [DefaultValue(0.00)]
        public string Category { get; set; }
        public string Image { get; set; }

    }
}
