using DiscOwl.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiscOwl.Controllers
{
    public class MusicController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("GetMusic");
        }

        public ActionResult GetMusic()
        {
            BaseViewModel vm = new BaseViewModel();
            vm.ViewTitle = "Music";

            return View(vm);
        }
    }
}