using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
