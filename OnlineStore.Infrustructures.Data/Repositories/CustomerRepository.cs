using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Contract.Repositories;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrustructures.Data.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineStore.Infrustructures.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly OnlineStoreContext context;
        public CustomerRepository(OnlineStoreContext context)
        {
            this.context = context;
        }
        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.AsEnumerable();
        }
        public Customer GetByID(int id)
        {
            return context.Customers.SingleOrDefault(s => s.Id == id);
        }
    }
}
