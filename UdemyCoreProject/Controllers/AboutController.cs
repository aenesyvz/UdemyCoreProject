using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
           
            var value = aboutManager.GetById(1);
            return View();
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.Update(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
