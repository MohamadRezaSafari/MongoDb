using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo
{
    public class MongoDatabaseAction
    {
        private readonly IMongoDatabase mongoDatabase;

        public MongoDatabaseAction(IMongoDatabase mongoDatabase)
        {
            this.mongoDatabase = mongoDatabase;
        }

        public void CreateCollection(string collectionName)
        {
            mongoDatabase.CreateCollection(collectionName);
        }

        public string DatabaseList()
        {
            var result = mongoDatabase.ListCollectionNames().ToList();

            return string.Join(',', result);
        }

        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return mongoDatabase.GetCollection<BsonDocument>(collectionName);
        }
    }
}