using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F.app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
//            var client = new MongoClient(connectionStringusing );
//            var db = client.GetDatabase("fapp");
//            var userCollection = db.GetCollection<BsonDocument>("test");
////            var document = new BsonDocument
////{
//    { "name", "MongoDB" },
//    { "type", "Database" },
//    { "count", 1 },
//    { "info", new BsonDocument
//        {
//            { "x", 203 },
//            { "y", 102 }
//        }}
//};
//            userCollection.InsertOne(document);
            return View(/*userCollection*/);
        }

        public ActionResult About()
        {
            ViewBag.Message = "The ultimate student convenience.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us here at the Student Food App:";

            return View();
        }
<<<<<<< HEAD
        public ActionResult Delivery()
        {
            ViewBag.Message = "Del us here at the Student Food App:";

            return View();
=======

        public ActionResult Delivery()
        {

         return View();
>>>>>>> cd63a05e81bce1eb6762adfc400ff5e704b98133
        }
    }
}