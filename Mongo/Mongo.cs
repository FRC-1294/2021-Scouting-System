using MongoDB.Bson;
using MongoDB.Driver;

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
        public void SendData(BsonDocument data)
        {
            mongoDatabase.GetCollection<BsonDocument>("Robots").InsertOne(data);
        }
        public System.Collections.Generic.List<BsonDocument> GetAggreation()
        {
            BsonDocument[] pipeline = new BsonDocument[]
{
    new BsonDocument("$group",
    new BsonDocument
        {
            { "_id", "$Team Number" },
            { "CommitAveragePowerCellsTop",
    new BsonDocument("$avg", "$PowerCells Top") },
            { "CommitSumPowerCellsBottom",
    new BsonDocument("$sum", "$PowerCells Bottom") }
        })
};
            return mongoDatabase.GetCollection<BsonDocument>("Robots").Aggregate<BsonDocument>(pipeline).ToList();
        }
    }
}
