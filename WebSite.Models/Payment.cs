using System;
using System.Collections.Generic;
using System.Text;

namespace WebSite.Models
{
    class Payment : BaseEntity
    {
        public DateTime Date { get; set; }
        public Cutomer Cutomer { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
