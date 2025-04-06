using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class StatistikController : Controller
    {
        // GET: Statistik

        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.TableCategory.Count();
            ViewBag.TestimonialCount = db.TableTestimonial.Count();
            ViewBag.ProjeSayisi = db.TableProject.Count();
            ViewBag.text = "veri";
            return View();
        }
    }
}