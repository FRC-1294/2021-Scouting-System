using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1294_Scouting.Mongo
{
    public class Mongo
    {
        const string mongoConnectionString = "mongodb://localhost:27017";
        const string mongoDatabaseName = "robotics-test";
        IMongoDatabase mongoDatabase;
        private MongoClient mongoManager;
        public Mongo()
        {
            mongoManager = new MongoClient(mongoConnectionString);
            mongoDatabase = mongoManager.GetDatabase(mongoDatabaseName);
        }
        public void SendData(BsonDocument data, int teamNumber)
        {
            mongoDatabase.GetCollection<BsonDocument>(teamNumber.ToString()).InsertOne(data);
        }
    }
}
