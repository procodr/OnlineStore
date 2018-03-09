using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Product Product { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}
