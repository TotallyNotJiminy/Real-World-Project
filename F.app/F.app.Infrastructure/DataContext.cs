using F.app.Core.Entities;
using F.app.Core.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Infrastructure
{
    public class DataContext
    {
        public const string connectionString/*Name*/ = "mongodb://aiwiss:1234@cluster0-shard-00-00-whjz1.mongodb.net:27017,cluster0-shard-00-01-whjz1.mongodb.net:27017,cluster0-shard-00-02-whjz1.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin";
        public const string DataBaseName = "test";

        private static readonly MongoClient _client;
        private static readonly MongoDatabase _db;
        //MongoDatabase db;

        static DataContext()
        {
            //var connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            _client = new MongoClient(connectionString);
            var server = _client.GetServer();
            _db = server.GetDatabase(DataBaseName);
        }
        public MongoCollection<TEntity> GetCollection<TEntity>()
        {
            {
                return _db.GetCollection<TEntity>(typeof(TEntity).Name.ToLower() + "s");
            }
        }
    }
}
