using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Widget.Models.Login;

namespace Template.Widget.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string name)
        {
            Login_VM viewModel = new Login_VM();

            viewModel.label1 = (name != null) ? name : "User Pleased";
            viewModel.login = "Log in Here !!!";

            return View(viewModel);
        }
    }
}