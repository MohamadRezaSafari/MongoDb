using MongoDB.Driver;

namespace Mongo
{
    public class MongoClientAction
    {
        private readonly MongoClient mongoClient;

        public MongoClientAction(MongoClient mongoClient)
        {
            this.mongoClient = mongoClient;
        }

        public IMongoDatabase GetDatabase(string dbName)
        {
            return mongoClient.GetDatabase(dbName);
        }

        public string DatabaseList()
        {
            var result = mongoClient.ListDatabaseNames().ToList();
            return string.Join(',', result);
        }

        public bool DropDatabase(string dbName)
        {
            mongoClient.DropDatabase(dbName);

            return true;
        }
    }
}