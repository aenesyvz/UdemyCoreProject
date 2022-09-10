using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCoreProject.ViewComponents.Dashboard
{
    public class MessageList: ViewComponent
    {
        //UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessageDal());
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public  IViewComponentResult Invoke()
        {
            //    var values = userMessageManager.GetAll();
            var values = messageManager.GetAll();
            return View(values);
        }
    }
}
