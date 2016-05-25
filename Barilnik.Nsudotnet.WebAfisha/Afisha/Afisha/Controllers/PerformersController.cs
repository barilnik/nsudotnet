using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Afisha.DAL;
using Afisha.Models;

namespace Afisha.Controllers
{
    public class PerformersController : Controller
    {
        private PostContext db = new PostContext();

        // GET: Performers
        public ActionResult Index()
        {
            
            var biography = new List<Biography>
            {
                new Biography { PerformerBiography = "COOL BIOGRAPHY" },
                new Biography { PerformerBiography = "BAD BIOGRAPHY" },
                new Biography { PerformerBiography = "So-so biography" }
            };
            var performers = new List<Performer>
            {
                new Performer { Name = "Queen", Country = "UK", Genre = "Rock" , Biography = biography[0] },
                new Performer { Name = "Nickelback", Country = "USA", Genre = "Rock" , Biography = biography[1] },
                new Performer { Name = "Byonce", Country = "USA", Genre = "POP" , Biography = biography[2] }
            };
            return View(performers);
            //return View(db.Performers.ToList());
        }
        
        // GET: Performers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Performer performer = db.Performers.Find(id);
            if (performer == null)
            {
                return HttpNotFound();
            }
            return View(performer);
        }

        // GET: Performers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Performers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PerformerID,Name,Country,Genre")] Performer performer)
        {
            if (ModelState.IsValid)
            {
                db.Performers.Add(performer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(performer);
        }

        // GET: Performers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Performer performer = db.Performers.Find(id);
            if (performer == null)
            {
                return HttpNotFound();
            }
            return View(performer);
        }

        // POST: Performers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PerformerID,Name,Country,Genre")] Performer performer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(performer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(performer);
        }

        // GET: Performers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Performer performer = db.Performers.Find(id);
            if (performer == null)
            {
                return HttpNotFound();
            }
            return View(performer);
        }

        // POST: Performers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Performer performer = db.Performers.Find(id);
            db.Performers.Remove(performer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}
