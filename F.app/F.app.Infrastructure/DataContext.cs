using F.app.Core.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Infrastructure
{
    public class DataContext
    {
        //MongoClient _client;
        //MongoServer _server;
        //MongoDatabase _db;
        public DataContext()
        {
            //    _client = new MongoClient("mongodb://aiwiss:A1234@ds131510.mlab.com:31510/fapp");
            //    _server = _client.GetServer();
            //    _db = _server.GetDatabase("fapp");
            var client = new MongoClient("mongodb://aiwiss:A1234@ds131510.mlab.com:31510/fapp");

            var db = client.GetDatabase("fapp");

            var collection = db.GetCollection<BsonDocument>("test");
            var document = new BsonDocument
                {
                    { "name", "MongoDB" },
                    { "type", "Database" },
                    { "count", 1 },
                    { "info", new BsonDocument
                    {
                        { "x", 203 },
                        { "y", 102 }
                    }
                }
                };
            collection.InsertOne(document);
        }
        //public MongoCollection<>
        
    }
}
