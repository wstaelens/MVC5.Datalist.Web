using Datalist.Web.Datalists;
using System;
using System.Web.Mvc;

namespace Datalist.Web.Controllers
{
    public class MvcDatalistController : Controller
    {
        public JsonResult Default(DatalistFilter filter, Int32? datalistAge)
        {
            filter.AdditionalFilters.Add("Age", datalistAge);

            return Json(new PeopleDatalist { Filter = filter }.GetData(), JsonRequestBehavior.AllowGet);
        }
    }
}
