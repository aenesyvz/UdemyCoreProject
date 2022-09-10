using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Controllers
{
    public class AjaxExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.GetAll());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.Add(experience);
            var values = JsonConvert.SerializeObject(experience);
            return Json(values);
        }
        public IActionResult GetById(int ExperienceId)
        {
            var experience = experienceManager.GetById(ExperienceId);
            var values = JsonConvert.SerializeObject(experience);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.GetById(id);
            experienceManager.Delete(values);
            return NoContent();
        }
    }
}
