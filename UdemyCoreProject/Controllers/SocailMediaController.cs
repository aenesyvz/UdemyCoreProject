using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Controllers
{
    public class SocailMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialMediaManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            socialMediaManager.Add(socialMedia);
            return RedirectToAction("Index", "SocialMedia");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = socialMediaManager.GetById(id);
            socialMediaManager.Delete(value);
            return RedirectToAction("Index", "SocialMedia");
        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = socialMediaManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.Update(socialMedia);
            return RedirectToAction("Index", "SocialMedia");
        }
    }
}
