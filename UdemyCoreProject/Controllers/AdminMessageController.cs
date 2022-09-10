using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListByReceiver(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListBySender(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.GetById(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.GetById(id);
            writerMessageManager.Delete(values);
            
            return RedirectToAction("ReceiverMessageList","AdminMessage");
        }
        public IActionResult AddAdminMessage(WriterMessage writerMessage)
        {
            writerMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            Context context = new Context();
            var userName = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = userName;
            writerMessageManager.Add(writerMessage);
            return RedirectToAction("SenderMessageList");
        }
    }
}
