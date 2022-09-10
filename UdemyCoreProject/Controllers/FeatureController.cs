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
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
           
            var value = featureManager.GetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.Update(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
