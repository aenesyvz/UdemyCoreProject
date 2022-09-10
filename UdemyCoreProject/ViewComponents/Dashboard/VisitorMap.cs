using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProject.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
