using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.ViewComponents.Dashboard
{
    public class StatisticDashboard2 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Protfolios.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Services.Count();
            return View();
        }
    }
}
