using F.app.Core.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace F.app.Models
{
    public class userDb
    {
        public string connectionString = "mongodb://aiwiss:1234@cluster0-shard-00-00-whjz1.mongodb.net:27017,cluster0-shard-00-01-whjz1.mongodb.net:27017,cluster0-shard-00-02-whjz1.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin";
        public string DataBaseName = "test";

        MongoDatabase db;

        public userDb()
        {
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            db = server.GetDatabase(DataBaseName);
            //var users = db.GetCollection<BsonDocument>("test");
            //BsonDocument document = new BsonDocument
            //{
            //    { "name" , "as"},
            //    {"lastName", "irgias" },
            //    { "ratingTable", new BsonArray
            //        {
            //            new BsonDocument
            //            {
            //                {"ratName", "desra" },
            //                {"rating", 10 }
            //            },
            //            new BsonDocument
            //            {
            //                {"ratName", "duona" },
            //                {"rating", "5" }
            //            }
            //        }
            //    }
            //};
            //var collection = db.GetCollection<BsonDocument>("test");
            //collection.Insert(document);
        }
        public MongoCollection<User> users
        {
            get
            {
                //var ratingTable = new BsonDocument().Add("_id", ).Add("Name", name);
                var users = db.GetCollection<User>("user");
                //users.InsertOne
                return users;
            }
        }
    }
}