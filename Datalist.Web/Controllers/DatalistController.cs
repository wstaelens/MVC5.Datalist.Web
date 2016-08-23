using System.Web.Mvc;
using System;

namespace Datalist.Web.Controllers
{
    public class DatalistController : Controller
    {
        [HttpGet]
        public ViewResult Title()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SourceUrl()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Localization()
        {
            return View();
        }

        [HttpGet]
        public ViewResult HiddenData()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AdditionalFilters()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DefaultSortOrder()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DefaultSortColumn()
        {
            return View();
        }

        [HttpGet]
        public ViewResult DefaultRows()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Autocomplete()
        {
            return View();
        }
    }
}
