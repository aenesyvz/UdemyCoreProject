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
    public class SubContentPlaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.GetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactManager.Update(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
