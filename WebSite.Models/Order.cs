using System;
using System.Collections.Generic;
using System.Text;

namespace WebSite.Models
{
    class Order : BaseEntity
    {
        public Product Product { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}
