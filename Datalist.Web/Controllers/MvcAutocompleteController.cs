using Datalist.Web.Datalists;
using System;
using System.Web.Mvc;

namespace Datalist.Web.Controllers
{
    public class MvcAutocompleteController : Controller
    {
        public JsonResult Default(DatalistFilter filter, Int32? autocompleteAge)
        {
            filter.AdditionalFilters.Add("Age", autocompleteAge);

            return Json(new PeopleAutocomplete() { Filter = filter }.GetData(), JsonRequestBehavior.AllowGet);
        }
    }
}
