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
    public struct cacheStruct
    {
        public int id;
        public string FirstName, Lastname;
    }
    public class CachedCustomerRepository : ICustomerRepository
    {
        private readonly OnlineStoreContext context;
        private ICustomerRepository customerRepository;
        private List<Customer> cache;
        public CachedCustomerRepository(OnlineStoreContext context)
        {
            this.context = context;
            customerRepository = new CustomerRepository(this.context);
            cache = new List<Customer>();
        }
        public IEnumerable<Customer> GetAll()
        {
            foreach (var val in customerRepository.GetAll())
            {
                Customer temp = new Customer() { Id = val.Id, FirstName = val.FirstName, Lastname = val.Lastname };
                if (!cache.Contains(temp)) cache.Add(temp);
            }
            return cache.AsEnumerable();
        }

        public Customer GetByID(int id)
        {
            foreach (var item in cache)
                if (item.Id == id) return item;
            var temp = customerRepository.GetByID(id);
            cache.Add(temp);
            return temp;
        }
    }
}
