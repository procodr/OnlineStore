using OnlineStore.Domain.Contract.Repositories;
using OnlineStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Infrustructures.Data.Repositories
{
    class CustomerRepository : ICustomerRepository
    {
        public Customer GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
