using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Widget.Models.Info;

namespace Template.Widget.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult Index()
        {
            Info_VM viewModel = new Info_VM();

            viewModel.description = "awd awd awd awd awd awd awd awd wd awd awd awdawd a";
            viewModel.title = "Login Information";

            return View(viewModel);
        }
    }
}