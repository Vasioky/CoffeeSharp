using System.Web.Mvc;

namespace MvcSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Sample()
        {
            return View();
        }
        
        public ActionResult SampleBundle()
        {
            return View();
        }
    }
}
