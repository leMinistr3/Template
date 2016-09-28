using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Widget.Models.PageList;
using Template.Widget.Utility;
using Kendo.Mvc.Extensions;

namespace Template.Widget.Controllers
{
    public class PageListController : Controller
    {
        private PageListUtility _utility = new PageListUtility();

        [HttpGet]
        public ActionResult Index()
        {
            PageList_VM viewModel = new PageList_VM();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult GetPageGridItems(DataSourceRequest dataSourceRequest)
        {
            return Json(_utility.GetPageGridItems().OrderBy(p => p.Name).ToDataSourceResult(dataSourceRequest), JsonRequestBehavior.AllowGet);
        }
    }
}