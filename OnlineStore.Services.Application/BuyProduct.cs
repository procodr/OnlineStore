using OnlineStore.Domain.Contract.Repositories;
using OnlineStore.Domain.Entities;
using System;

namespace OnlineStore.Services.Application
{
    public class BuyProduct
    {
        public ICustomerRepository CustomerRepository { get; set; }
        public void Buy(Product product)
        {
            CustomerRepository.GetByID(10);
        }
    }
}
