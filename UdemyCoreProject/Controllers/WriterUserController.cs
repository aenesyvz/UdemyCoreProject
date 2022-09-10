using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUserManager.GetAll());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(WriterUser writerUser)
        {
            writerUserManager.Add(writerUser);
            var values = JsonConvert.SerializeObject(writerUser);
            return View(values);
        }
    }
}
