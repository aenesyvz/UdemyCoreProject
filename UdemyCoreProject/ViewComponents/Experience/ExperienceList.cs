using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyCoreProject.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experienceManager.GetAll();
            return View(values);
        }
    }
}
