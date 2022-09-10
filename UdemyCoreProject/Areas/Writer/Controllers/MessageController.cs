using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userManager;
        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            var messages = writerMessageManager.GetListByReceiver(mail);
            return View(messages);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            var messages = writerMessageManager.GetListBySender(mail);
            return View(messages);
        }
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            var values = writerMessageManager.GetById(id);
            return View(values);
        }
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            var values = writerMessageManager.GetById(id);
            return View(values);
        }
        [HttpGet]
        [Route("")]
        [Route("AddMessage")]
        public IActionResult AddMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("AddMessage")]
        public async Task<IActionResult> AddMessage(WriterMessage writerMessage)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            writerMessage.Sender = values.Email;
            writerMessage.SenderName = values.Name + " " + values.Surname;
            writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            Context context = new Context();
            var receiverName = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = receiverName;
            writerMessageManager.Add(writerMessage);
            return RedirectToAction("SenderMessage", "Message");
        }
    }
}
