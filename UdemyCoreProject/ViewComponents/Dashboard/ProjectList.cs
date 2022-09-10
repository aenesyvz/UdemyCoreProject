using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProject.ViewComponents.Dashboard
{
    public class ProjectList : ViewComponent
    {
        ProtfolioManager protfolioManager = new ProtfolioManager(new EfProtfolioDal());
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
