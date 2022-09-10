using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        ProtfolioManager protfolioManager = new ProtfolioManager(new EfProtfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = protfolioManager.GetAll().OrderByDescending(x => x.ProtfolioId).Take(5).ToList();
            return View(values);
        }
    }
}
