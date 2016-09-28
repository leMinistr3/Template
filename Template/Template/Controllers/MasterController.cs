using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Template.Models.Master;
using Template.Template.Utility;

namespace Template.Template.Controllers
{
    public class MasterController : Controller
    {
        MasterUtility _util = new MasterUtility();

        // GET: Master
        [HttpGet]
        public ActionResult Index(string pageName)
        {
            Master_VM viewModel = new Master_VM();

            viewModel.pageName = pageName;

            _util.GetRequestedPage(viewModel);

            return View(viewModel.viewName, viewModel);
        }
    }
}