using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TableAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var deger = db.TableServices.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PartialTestimonial()
        {
            var deger = db.TableTestimonial.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PartialContact()
        {
            var deger = db.TableContact.ToList();
            return PartialView(deger);
        }

        [HttpGet]
        public ActionResult PartialMessage()
        {
            var deger = db.TableMessage.ToList();
            return PartialView(deger);
        }

        [HttpPost]

        public ActionResult PartialMessage(TableMessage message)
        {
            db.TableMessage.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult PartialSlider()
        {
            var deger = db.TableSlider.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PartialSkill()
        {
            var deger = db.TableSkill.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PartialEducation()
        {
            var deger = db.TableEducation.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PartialJob()
        {
            var deger = db.TableJob.ToList();
            return PartialView(deger);
        }

        public PartialViewResult PartialProject()
        {
            var deger = db.TableProject.ToList();
            return PartialView(deger);
        }
    }
}