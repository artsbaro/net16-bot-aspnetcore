using MongoDB.Driver;
using SimpleBotCoreDomain.Entities;

namespace SimpleBotCoreMongoDB
{
    public class MongoDBData
    {
        public void Insert(SimpleMessage message)
        {
            try
            {
                IMongoClient client = new MongoClient("mongodb://localhost:27017");

                IMongoDatabase database = client.GetDatabase("net16");

                var col = database.GetCollection<SimpleMessage>("col01");

                col.InsertOne(message);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
