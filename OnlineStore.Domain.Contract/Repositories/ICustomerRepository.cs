using System;
using System.Collections.Generic;
using System.Text;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Contract.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetByID(int id);
    }
}
