using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableJob.ToList();
            return View(values);
        }

        public ActionResult DeleteJob(int id)
        {
            var values = db.TableJob.Find(id);
            db.TableJob.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatJob(TableJob job)
        {
            db.TableJob.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateJob(int id)
        {
            var values = db.TableJob.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateJob(TableJob model)
        {
            var value = db.TableJob.Find(model.JobID);
            value.Title = model.Title;
            value.StartDate = model.StartDate;
            value.EndDate = model.EndDate;
            value.CompanyName = model.CompanyName;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}