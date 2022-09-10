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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
          
            var value = serviceManager.GetAll();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.Add(service);
            return RedirectToAction("Index", "Default");
        }
        public IActionResult DeleteService(int id)
        {
            var value = serviceManager.GetById(id);
            serviceManager.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = serviceManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceManager.Update(service);
            return RedirectToAction("Index");
        }
    }
}
