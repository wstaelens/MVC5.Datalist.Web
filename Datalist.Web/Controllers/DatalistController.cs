using Datalist.Web.Datalists;
using System;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Datalist.Web.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class DatalistController : Controller
    {
        private JsonResult GetData(AbstractDatalist datalist, DatalistFilter filter)
        {
            datalist.CurrentFilter = filter;

            return Json(datalist.GetData(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Default(DatalistFilter filter)
        {
            return GetData(new DefaultDatalist(), filter);
        }
        public JsonResult Data(DatalistFilter filter)
        {
            return GetData(new DatalistDataDatalist(), filter);
        }
        public JsonResult DifferentUrlExample(DatalistFilter filter, String AdditionalFilterId)
        {
            filter.AdditionalFilters.Add("Id", AdditionalFilterId);

            return GetData(new ExampleDatalist(), filter);
        }

        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Installation()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Examples()
        {
            return View();
        }

        [HttpGet]
        public ActionResult API()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Tests()
        {
            return View();
        }
    }
}
