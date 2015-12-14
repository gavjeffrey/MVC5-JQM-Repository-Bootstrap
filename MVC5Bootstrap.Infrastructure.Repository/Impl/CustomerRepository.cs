using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Linq;
using MVC5Bootstrap.Domain;

namespace MVC5Bootstrap.Infrastructure.Repository.Impl
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Create(Customer entity)
        {
            InMemCustomerStore.Customers.Add(entity);
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll()
        {
            return InMemCustomerStore.Customers;
        }

        public IList<Customer> GetCustomerByName(string Name)
        {
            Name = Name.ToLower();
            return InMemCustomerStore.Customers.Where(x => x.FirstName.ToLower().Contains(Name) 
                                                           || x.Surname.ToLower().Contains(Name)).ToList();
        }
    }
}
