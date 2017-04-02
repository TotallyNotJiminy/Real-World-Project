using F.app.Core.Entities;
using F.app.Core.Interfaces;
using F.app.Infrastructure;
using F.app.Models;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F.app.Controllers
{
    public class UsersController : Controller
    {
        private IRepo<User,ObjectId> _context;
        private IRepo<Ingredient, ObjectId> _IngrContext;
   
        public UsersController(IRepo<User,ObjectId> context, IRepo<Ingredient,ObjectId> ingrContext)
        {
            this._context = context;
            this._IngrContext = ingrContext;
        }        
        // GET: Users
        public ActionResult Index()
        {
            var users = _context.List();

            return View(users);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult startRating(int id)
        {
            List<Recipe> randomRecipes = new List<Recipe>();
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(User _user)
        {
            try
            {
                List<ingRating> ratingsTable = new List<ingRating>();
       
                for (var i = 0; i < _IngrContext.List().Count(); i++)
                    ratingsTable.Add(new ingRating {ingrName= _IngrContext.List()[i].Name,rating=0 });

                _user.ratings = ratingsTable;
                _context.Insert(_user);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
