using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableSlider.ToList();
            return View(values);
        }
        public ActionResult DeleteSlider(int id)
        {
            var values = db.TableSlider.Find(id);
            db.TableSlider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatSlider()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatSlider(TableSlider slider)
        {
            db.TableSlider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var values = db.TableSlider.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSlider(TableSlider model)
        {
            var value = db.TableSlider.Find(model.SliderID);
            value.NameSurname = model.NameSurname;
            value.Description = model.Description;
            value.ImageURL = model.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}