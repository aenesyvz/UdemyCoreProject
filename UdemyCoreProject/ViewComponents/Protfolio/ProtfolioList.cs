using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.ViewComponents.Protfolio
{
    public class ProtfolioList : ViewComponent
    {
        ProtfolioManager protfolioManager = new ProtfolioManager(new EfProtfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = protfolioManager.GetAll();
            return View(values);
        }
    }
}
