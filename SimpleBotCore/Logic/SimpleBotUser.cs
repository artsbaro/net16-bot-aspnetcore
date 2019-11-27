using SimpleBotCoreDomain.Entities;
using SimpleBotCoreMongoDB;

namespace SimpleBotCore.Logic
{
    public class SimpleBotUser
    {
        protected readonly MongoDBData _db;

        public SimpleBotUser(MongoDBData db)
        {
            _db = db;
        }

        public string Reply(SimpleMessage message)
        {
            _db.Insert(message);
            return $"{message.User} disse '{message.Text}'";
        }
    }
}
