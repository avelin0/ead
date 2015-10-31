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
    public class PaginasController : Controller
    {
        private EadContext db = new EadContext();

        // GET: Paginas
        public ActionResult Index()
        {
            return View(db.Paginas.ToList());
        }

        // GET: Paginas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagina pagina = db.Paginas.Find(id);
            if (pagina == null)
            {
                return HttpNotFound();
            }
            return View(pagina);
        }

        // GET: Paginas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paginas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaginaID,Name,CreationDate")] Pagina pagina)
        {
            if (ModelState.IsValid)
            {
                db.Paginas.Add(pagina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pagina);
        }

        // GET: Paginas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagina pagina = db.Paginas.Find(id);
            if (pagina == null)
            {
                return HttpNotFound();
            }
            return View(pagina);
        }

        // POST: Paginas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PaginaID,Name,CreationDate")] Pagina pagina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pagina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pagina);
        }

        // GET: Paginas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagina pagina = db.Paginas.Find(id);
            if (pagina == null)
            {
                return HttpNotFound();
            }
            return View(pagina);
        }

        // POST: Paginas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pagina pagina = db.Paginas.Find(id);
            db.Paginas.Remove(pagina);
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
