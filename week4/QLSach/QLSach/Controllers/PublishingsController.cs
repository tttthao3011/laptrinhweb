using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLSach.Model;
using QLSach.Models;

namespace QLSach.Controllers
{
    public class PublishingsController : Controller
    {
        private QLSachContext db = new QLSachContext();

        // GET: Publishings
        public ActionResult Index()
        {
            return View(db.Publishings.ToList());
        }

        // GET: Publishings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publishing publishing = db.Publishings.Find(id);
            if (publishing == null)
            {
                return HttpNotFound();
            }
            return View(publishing);
        }

        // GET: Publishings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publishings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PublishingId,PublishingName")] Publishing publishing)
        {
            if (ModelState.IsValid)
            {
                db.Publishings.Add(publishing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publishing);
        }

        // GET: Publishings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publishing publishing = db.Publishings.Find(id);
            if (publishing == null)
            {
                return HttpNotFound();
            }
            return View(publishing);
        }

        // POST: Publishings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PublishingId,PublishingName")] Publishing publishing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publishing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publishing);
        }

        // GET: Publishings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publishing publishing = db.Publishings.Find(id);
            if (publishing == null)
            {
                return HttpNotFound();
            }
            return View(publishing);
        }

        // POST: Publishings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Publishing publishing = db.Publishings.Find(id);
            db.Publishings.Remove(publishing);
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
