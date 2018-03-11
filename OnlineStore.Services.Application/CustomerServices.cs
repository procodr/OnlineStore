using OnlineStore.Domain.Contract.Repositories;
using OnlineStore.Domain.Entities;
using System;
using System.Collections;

namespace OnlineStore.Services.Application
{
    public class CustomerServices : ICustomerServices
    {
        private ICustomerRepository CustomerRepository { get; set; }
        public CustomerServices(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }
        public IEnumerable GetEnumerable()
        {
            return CustomerRepository.GetAll();
        }
    }
}
