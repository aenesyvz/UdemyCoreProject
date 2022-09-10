using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UdemyCoreProject.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message message)
        //{
            
        //    return View();
        //}
    }
}
