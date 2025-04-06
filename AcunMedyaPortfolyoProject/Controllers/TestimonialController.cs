using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableTestimonial.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.TableTestimonial.Find(id);
            db.TableTestimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatTestimonial(TableTestimonial testimonial)
        {
            db.TableTestimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.TableTestimonial.Find(id);
            return View("UpdateTestimonial", values);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(TableTestimonial testimonial)
        {
            var values = db.TableTestimonial.Find(testimonial.TestimonialID);
            values.Description = testimonial.Description;
            values.Description2 = testimonial.Description2;
            values.ImageURL = testimonial.ImageURL;
            values.TestimonialName = testimonial.TestimonialName;
            values.Title = testimonial.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}