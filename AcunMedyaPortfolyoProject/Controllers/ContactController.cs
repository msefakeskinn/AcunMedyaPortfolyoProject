using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableContact.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.TableContact.Find(id);
            db.TableContact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatContact(TableContact contact)
        {
            db.TableContact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = db.TableContact.Find(id);
            return View("UpdateContact", values);
        }

        [HttpPost]
        public ActionResult UpdateContact(TableContact contact)
        {
            var values = db.TableContact.Find(contact.ContactID);
            values.Description = contact.Description;
            values.Adress = contact.Adress;
            values.Email = contact.Email;
            values.Phone = contact.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}