using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UdemyCoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;            
        }
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            //WEATHER API

            string api = "2134448fdd97fbf056efac52a7f2f4ad";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Tosya&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument xDocument = XDocument.Load(connection);
            ViewBag.v5 = xDocument.Descendants("temperature ").ElementAt(0).Attribute("value").Value;


            Context context = new Context();
            ViewBag.v1 = context.WriterMessages.Where(x=>x.Receiver == values.Email).Count();
            ViewBag.v2 = context.Announcements.Count();
            ViewBag.v3 = context.Users.Count();
            ViewBag.v4 = context.Skills.Count();
            return View();
        }
    }
}
