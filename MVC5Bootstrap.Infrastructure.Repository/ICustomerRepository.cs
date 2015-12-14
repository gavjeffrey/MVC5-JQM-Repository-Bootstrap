using MVC5Bootstrap.Domain;
using System.Collections.Generic;

namespace MVC5Bootstrap.Infrastructure.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IList<Domain.Customer> GetCustomerByName(string Name);
    }
}
