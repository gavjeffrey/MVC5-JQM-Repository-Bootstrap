using System.Web.Mvc;

namespace MVC5Bootstrap.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void ExecuteCore()
        {
            base.ExecuteCore();
        }

        protected override void OnActionExecuting(ActionExecutingContext ctx)
        {
            base.OnActionExecuting(ctx);
        }
    }
}