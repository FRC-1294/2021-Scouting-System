using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1294_Scouting.Mongo
{
    public class Mongoz
    {
        private MongoClient mongoManager;
        public Mongoz()
        {
            mongoManager = new MongoClient("mongodb://localhost:27017");

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
    }
}
