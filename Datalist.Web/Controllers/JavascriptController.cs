using Datalist.Web.Datalists;
using System;
using System.Web.Mvc;

namespace Datalist.Web.Controllers
{
    public class JavascriptController : Controller
    {
        [HttpGet]
        public ViewResult Api()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Reload()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Browse()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Select()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Readonly()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SelectFirst()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SelectSingle()
        {
            return View();
        }

        [HttpGet]
        public ViewResult FilterChange()
        {
            return View();
        }


        [HttpGet]
        public JsonResult AllPeople(DatalistFilter filter, Int32? autocompleteIncome, Int32? datalistIncome, Boolean? isWorking)
        {
            filter.AdditionalFilters["IsWorking"] = isWorking;
            filter.AdditionalFilters["Income"] = autocompleteIncome ?? datalistIncome;

            return Json(new PeopleDatalist { Filter = filter }.GetData(), JsonRequestBehavior.AllowGet);
        }
    }
}
