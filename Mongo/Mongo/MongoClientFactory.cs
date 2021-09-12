using MongoDB.Driver;

namespace Mongo
{
    public class MongoClientFactory
    {
        public MongoClient GetDefaultConstructor()
        {
            return new MongoClient();
        }

        public MongoClient GetConnectionString()
        {
            return new MongoClient("mongodb://localhost:27017");
        }

        public MongoClient GetUrl(bool useUrlCreator = true)
        {
            return useUrlCreator
                ? new MongoClient(MongoUrl.Create("mongodb:localhost:27017"))
                : new MongoClient(new MongoUrl("mongodb:localhost:27017"));
        }

        public MongoClient GetSettingFromUrl()
        {
            var setting = MongoClientSettings.FromUrl(MongoUrl.Create("mongodb:localhost:27017"));
            return new MongoClient(setting);
        }

        public MongoClient GetSetting()
        {
            var setting = new MongoClientSettings()
            {
                Server = new MongoServerAddress("mongodb:localhost:27017"),
            };

            return new MongoClient(setting);
        }
    }
}
