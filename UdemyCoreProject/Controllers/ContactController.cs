using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.GetAll();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = messageManager.GetById(id);
            messageManager.Delete(values);
            return RedirectToAction("Index", "Message");
        }
        public IActionResult ContactDetails(int id)
        {
            var values = messageManager.GetById(id);
            return View(values);
        }
    }
}
