using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableServices.ToList();
            return View(values);
        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.TableServices.Find(id);
            db.TableServices.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreatServices()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatServices(TableServices services)
        {
            db.TableServices.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = db.TableServices.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateServices(TableServices model)
        {
            var value = db.TableServices.Find(model.ServicesID);
            value.Title = model.Title;
            value.Description = model.Description;
            value.Description2 = model.Description2;
            value.IconURL = model.IconURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
     }
}