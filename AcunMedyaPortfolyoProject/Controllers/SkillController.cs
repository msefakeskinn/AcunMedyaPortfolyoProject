using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableSkill.ToList();
            return View(values);
        }
        public ActionResult DeleteSkill(int id)
        {
            var values = db.TableSkill.Find(id);
            db.TableSkill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatSkill(TableSkill skill)
        {
            db.TableSkill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var values = db.TableSkill.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TableSkill model)
        {
            var value = db.TableSkill.Find(model.SkillID);
            value.SkillName = model.SkillName;
            value.Percentage = model.Percentage;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}