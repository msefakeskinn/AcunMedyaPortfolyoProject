using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableProject.ToList();
            return View(values);
        }

        public ActionResult DeleteProject(int id)
        {
            var values = db.TableProject.Find(id);
            db.TableProject.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatProject()
        {
            List<SelectListItem> categories = (from i in db.TableCategory.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.CategoryName,
                                               Value = i.CategoryID.ToString()
                                           }).ToList();
            ViewBag.categories = categories;
            return View();
        }
        [HttpPost]
        public ActionResult CreatProject(TableProject project)
        {
            List<SelectListItem> categories = (from i in db.TableCategory.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryID.ToString()
                                             }).ToList();
            ViewBag.categories = categories;
            if (!ModelState.IsValid)
            {
                db.TableProject.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(project);

        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            List<SelectListItem> categories = (from i in db.TableCategory.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryID.ToString()
                                             }).ToList();
            ViewBag.categories = categories;
            var value = db.TableProject.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProject(TableProject model)
        {
            var categoryList = db.TableCategory.ToList();

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();

            ViewBag.categories = categories;
           
            var value = db.TableProject.Find(model.ProjectID);

            value.ProjectName = model.ProjectName;
            value.Description = model.Description;
            value.ProjectLink = model.ProjectLink;
            value.İmage1 = model.İmage1;
            value.İmage2 = model.İmage2;
            value.İmage3 = model.İmage3;
            value.CategoryID = model.CategoryID;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
