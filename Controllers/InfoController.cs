using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormApplication.Models;

namespace FormApplication.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Information info)
        {
            return View(info);
        }
    }
}