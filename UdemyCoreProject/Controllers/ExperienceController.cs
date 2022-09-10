using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experienceManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.Add(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = experienceManager.GetById(id);
            experienceManager.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
       
            var value = experienceManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.Update(experience);
            return RedirectToAction("Index");
        }
    }
}
