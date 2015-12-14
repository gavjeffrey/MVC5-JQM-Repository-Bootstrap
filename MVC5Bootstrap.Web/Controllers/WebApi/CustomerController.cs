using MVC5Bootstrap.Infrastructure.Repository;
using System.Collections.Generic;
using System.Web.Http;

namespace MVC5Bootstrap.Web.Controllers.WebApi
{
    public class CustomerController : ApiController
    {
        ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpGet]
        [Route("api/Customer/{Name}")]
        public IEnumerable<Domain.Customer> GetCustomerByNameSearch(string Name)
        {
            return customerRepository.GetCustomerByName(Name);
        }
    }
}
