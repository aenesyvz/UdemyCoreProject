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
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
           
            var values = skillManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.Add(skill);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteSkill(int id)
        {
            var value = skillManager.GetById(id);
            skillManager.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = skillManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            skillManager.Update(skill);
            return RedirectToAction("Index");
        }
    }
}
