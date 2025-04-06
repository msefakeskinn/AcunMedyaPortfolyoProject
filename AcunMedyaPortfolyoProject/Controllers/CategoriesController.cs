
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;
namespace AcunMedyaPortfolyoProject.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
           var values = db.TableCategory.ToList();
            return View(values);
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = db.TableCategory.Find(id);
            db.TableCategory.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatCategory(TableCategory category) 
        {
            db.TableCategory.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.TableCategory.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TableCategory model)
        {
            var value = db.TableCategory.Find(model.CategoryID);
            value.CategoryName = model.CategoryName;
            db.SaveChanges();  
            return RedirectToAction("Index");
        }



    }
}