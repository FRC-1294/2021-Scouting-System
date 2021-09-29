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
        const string mongoCollectionName = "Auburn";
        IMongoCollection<BsonDocument> mongoCollection;
        private MongoClient mongoManager;
        public Mongo()
        {
            mongoManager = new MongoClient(mongoConnectionString);
            mongoCollection = mongoManager.GetDatabase(mongoDatabaseName).GetCollection<BsonDocument>(mongoCollectionName);
        }
        public void RefreshCollection()
        {
            mongoCollection = mongoManager.GetDatabase(mongoDatabaseName).GetCollection<BsonDocument>(mongoCollectionName);
        }
        public void SendData(RobotMatchData data)
        {
            RefreshCollection();
            mongoCollection.InsertOne(data.GetMongoDocument());
        }
    }
}
