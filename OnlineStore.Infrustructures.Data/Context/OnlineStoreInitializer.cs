using OnlineStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineStore.Infrustructures.Data.Context
{
    public static class OnlineStoreInitializer
    {
        public static void Initialize(OnlineStoreContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customers.Any()) return;

            var Customers = new Customer[]
            {
                new Customer{FirstName = "AliReza", Lastname = "Mahmudi"},
                new Customer{FirstName = "AliReza", Lastname = "Orumand"},
                new Customer{FirstName = "Mehrdad", Lastname = "Saheb"},
                new Customer{FirstName = "Ali", Lastname = "Sheykh Nezami"}
            };

            foreach (var customer in Customers) context.Customers.Add(customer);

            context.SaveChanges();
        }
    }
}
