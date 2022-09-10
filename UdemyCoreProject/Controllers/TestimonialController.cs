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
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            testimonialManager.Add(testimonial);
            return RedirectToAction("Index","Testimonial");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = testimonialManager.GetById(id);
            testimonialManager.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = testimonialManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            testimonialManager.Update(testimonial);
            return View("Index");
        }
    }
}
