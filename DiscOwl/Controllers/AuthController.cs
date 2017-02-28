using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiscOwl.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Register");
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}