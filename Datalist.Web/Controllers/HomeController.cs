using System.Web.Mvc;

namespace Datalist.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Installation()
        {
            return View();
        }
    }
}
