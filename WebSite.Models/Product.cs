using System;
using System.Collections.Generic;
using System.Text;

namespace WebSite.Models
{
    class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductCategory Category { get; set; }
    }
}
