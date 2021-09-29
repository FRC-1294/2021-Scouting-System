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
        IMongoCollection<BsonDocument> mongoCollection;
        private MongoClient mongoManager;
        public Mongo()
        {
            mongoManager = new MongoClient("mongodb://localhost:27017");
            mongoCollection = mongoManager.GetDatabase("robotics-test").GetCollection<BsonDocument>("Auburn");
        }
        public void goBrr()
        {
            IMongoDatabase database = mongoManager.GetDatabase("robotics-test");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("Auburn");
            collection.InsertOne(new BsonDocument {
                    {"Team#", 1294 },
                    {"Cells", 24 }
                });
        }
        public void refreshCollection()
        {
            mongoCollection = mongoManager.GetDatabase("robotics-test").GetCollection<BsonDocument>("Auburn");
        }
        public void sendData(RobotMatchData data)
        {
            refreshCollection();
            mongoCollection.InsertOne(data.GetMongoDocument());
        }
    }
}
