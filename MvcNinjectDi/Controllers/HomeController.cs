using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcNinjectDi.Entities;
using MvcNinjectDi.Interfaces;
using Ninject;

namespace MvcNinjectDi.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;
        public HomeController(IRepository r)
        {
            repo = r;
        }
        public ActionResult Index()
        {
            return View(repo.List());
        }
    }
}