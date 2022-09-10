using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProject.ViewComponents.Dashboard
{
    public class ToDoListComponent : ViewComponent
    {
        ToDoManager toDoManager = new ToDoManager(new EfToDoDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoManager.GetAll();
            return View(values);
        }
    }
}
