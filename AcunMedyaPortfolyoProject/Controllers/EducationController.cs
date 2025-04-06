using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableEducation.ToList();
            return View(values);
        }

        public ActionResult DeleteEducation(int id)
        {
            var values = db.TableEducation.Find(id);
            db.TableEducation.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatEducation(TableEducation education)
        {
            db.TableEducation.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var values = db.TableEducation.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TableEducation model)
        {
            var value = db.TableEducation.Find(model.EducationID);
            value.StartYear = model.StartYear;
            value.EndYear = model.EndYear;
            value.Name = model.Name;
            value.Description = model.Description;
            value.Section = model.Section;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}