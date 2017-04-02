using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using F.app.Core.Entities;
using F.app.Models;
using F.app.Core.Interfaces;
using MongoDB.Bson;

namespace F.app.Controllers
{
    public class IngredientsController : Controller
    {
        private IRepo<Ingredient, ObjectId> _context;

        public IngredientsController(IRepo<Ingredient, ObjectId> context)
        {
            this._context = context;
        }
        // GET: Ingredients
        public ActionResult Index()
        {
            return View(_context.List());
        }

        // GET: Ingredients/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Ingredient ingredient = db.Ingredients.Find(id);
        //    if (ingredient == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(ingredient);
        //}

        // GET: Ingredients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingredients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,AllergyCategory,PricePerUnitOfMeasure,CalPerUnitOfMeasure")] Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(ingredient);
                return RedirectToAction("Index");
            }

            return View(ingredient);
        }

        // GET: Ingredients/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Ingredient ingredient = db.Ingredients.Find(id);
        //    if (ingredient == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(ingredient);
        //}

        // POST: Ingredients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "id,Name,AllergyCategory,PricePerUnitOfMeasure,CalPerUnitOfMeasure")] Ingredient ingredient)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(ingredient).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(ingredient);
        //}

        // GET: Ingredients/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Ingredient ingredient = db.Ingredients.Find(id);
        //    if (ingredient == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(ingredient);
        //}

        // POST: Ingredients/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    Ingredient ingredient = db.Ingredients.Find(id);
        //    db.Ingredients.Remove(ingredient);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
