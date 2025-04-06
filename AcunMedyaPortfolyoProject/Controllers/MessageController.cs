using AcunMedyaPortfolyoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DBAcunmedyaProject1Entities1 db = new DBAcunmedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.TableMessage.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = db.TableMessage.Find(id);
            db.TableMessage.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreatMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatMessage(TableMessage message)
        {
            db.TableMessage.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateMessage(int id) 
        { var values = db.TableMessage.Find(id);
          return View(values);
        }

        [HttpPost]
        public ActionResult UpdateMessage(TableMessage model)
        {
            var value = db.TableMessage.Find(model.MessageID);
            value.NameSurname = model.NameSurname;
            value.Mail = model.Mail;
            value.Subject = model.Subject;
            value.MessageContent = model.MessageContent;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
