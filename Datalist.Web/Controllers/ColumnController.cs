using System.Web.Mvc;

namespace Datalist.Web.Controllers
{
    public class ColumnController : Controller
    {
        [HttpGet]
        public ViewResult Header()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CssClass()
        {
            return View();
        }
    }
}
