using System.Web.Mvc;

namespace MVC5Bootstrap.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View("Error");
        }
    }
}