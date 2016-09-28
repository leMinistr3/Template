using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Widget.Models.News;

namespace Template.Widget.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index(int? num, string title = null)
        {
            News_VM viewModel = new News_VM();

            viewModel.newsTitle = (title != null) ? title : "Welcome in News !!!";
            viewModel.number = (num != null) ? num.Value : 0;

            return View(viewModel);
        }
    }
}