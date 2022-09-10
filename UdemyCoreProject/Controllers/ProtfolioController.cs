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
    public class ProtfolioController : Controller
    {
        ProtfolioManager protfolioManager = new ProtfolioManager(new EfProtfolioDal());
        public IActionResult Index()
        {
            var values = protfolioManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProtfolio()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult AddProtfolio(Protfolio protfolio)
        {
            protfolioManager.Add(protfolio);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProtfolio(int id)
        {
            var value = protfolioManager.GetById(id);
            protfolioManager.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProtfolio(int id)
        {
            var value = protfolioManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProtfolio(Protfolio protfolio)
        {
            protfolioManager.Update(protfolio);
            return RedirectToAction("Index");
        }
    }
}
