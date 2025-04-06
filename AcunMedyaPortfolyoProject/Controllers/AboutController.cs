using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AcunMedyaPortfolyoProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableAbout.ToList();
            return View(values);
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db.TableAbout.Find(id);
            db.TableAbout.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreatAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatAbout(TableAbout about)
        {
            db.TableAbout.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.TableAbout.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateAbout(TableAbout model)
        {
            var value = db.TableAbout.Find(model.AboutID);
            value.ImageURL = model.ImageURL;
            value.Title = model.Title;
            value.BirthDay = model.BirthDay;
            value.WebSite = model.WebSite;
            value.Phone = model.Phone;
            value.City = model.City;
            value.Age = model.Age;
            value.Email = model.Email;
            value.Freelance = model.Freelance;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.Degree = model.Degree;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}