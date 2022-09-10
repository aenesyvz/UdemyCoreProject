using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProject.ViewComponents.Dashboard
{
    public class UserMessageList : ViewComponent
    {
        //UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
