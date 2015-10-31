using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EAD.Models;

namespace EAD.Controllers
{
    public class TopicoesController : Controller
    {
        private EadContext db = new EadContext();

        // GET: Topicoes
        public ActionResult Index()
        {
            return View(db.Topicoes.ToList());
        }

        // GET: Topicoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topicoes.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            return View(topico);
        }

        // GET: Topicoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Topicoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopicoID,Name,CreationDate")] Topico topico)
        {
            if (ModelState.IsValid)
            {
                db.Topicoes.Add(topico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(topico);
        }

        // GET: Topicoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topicoes.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            return View(topico);
        }

        // POST: Topicoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TopicoID,Name,CreationDate")] Topico topico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(topico);
        }

        // GET: Topicoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topicoes.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            return View(topico);
        }

        // POST: Topicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Topico topico = db.Topicoes.Find(id);
            db.Topicoes.Remove(topico);
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
