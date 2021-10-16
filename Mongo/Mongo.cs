using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading;

namespace _1294_Scouting.Mongo
{
    public class Mongo
    {
        //const string mongoConnectionString = "mongodb://localhost:27017";
        const string mongoDatabaseName = "robotics";
        IMongoDatabase mongoDatabase;
        private MongoClient mongoManager;
        public Mongo(string connectionString)
        {
            mongoManager = new MongoClient(connectionString);
            mongoDatabase = mongoManager.GetDatabase(mongoDatabaseName);
        }
        public void SendMatchData(BsonDocument data)
        {
            mongoDatabase.GetCollection<BsonDocument>("Matches").InsertOne(data);            
        }
        public void SendPreScoutData(BsonDocument data)
        {
            mongoDatabase.GetCollection<BsonDocument>("PreScout").InsertOne(data);
        }
        public BsonDocument GetConfigFromServer()
        {
            return mongoDatabase.GetCollection<BsonDocument>("Config").Find(new BsonDocument{ }).FirstOrDefault();
        }

        public void SendData(BsonDocument data, string collection)
        {
            mongoDatabase.GetCollection<BsonDocument>(collection).InsertOne(data);
        }
        public void NukeConfig()
        {
            mongoDatabase.DropCollection("Config");
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
