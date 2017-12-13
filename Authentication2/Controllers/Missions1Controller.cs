using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Authentication2.DAL;
using Authentication2.Models;

namespace Authentication2.Controllers
{
    public class Missions1Controller : Controller
    {
        private MissionSiteContext db = new MissionSiteContext();

        // GET: Missions1
        public ActionResult Index()
        {
            return View(db.Missions.ToList());
        }

        // GET: Missions1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Missions.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // GET: Missions1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Missions1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MissionID,MissionName,PresidentName,Address,Language,Climate,Religion,Picture")] Missions missions)
        {
            if (ModelState.IsValid)
            {
                db.Missions.Add(missions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missions);
        }

        // GET: Missions1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Missions.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // POST: Missions1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MissionID,MissionName,PresidentName,Address,Language,Climate,Religion,Picture")] Missions missions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(missions);
        }

        // GET: Missions1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Missions.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // POST: Missions1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Missions missions = db.Missions.Find(id);
            db.Missions.Remove(missions);
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
