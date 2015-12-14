using MVC5Bootstrap.Infrastructure.Repository;
using System.Web.Mvc;

namespace MVC5Bootstrap.Web.Controllers
{
    [RequireHttps]
    //[Authorize]
    public class HomeController : Controller
    {   
        ICustomerRepository customerRepository;
        public HomeController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IScrollDemo()
        {
            return View();
        }
        public ActionResult FilterDemo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Models.CustomerViewModel CustomerViewModel)
        {
            var customer = AutoMapper.Mapper.Map<Domain.Customer>(CustomerViewModel);
            customerRepository.Create(customer);
            
            return RedirectToAction("FilterDemo");
        }        
    }
}
