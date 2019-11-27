using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SimpleBotCoreDomain.Entities
{
    public class SimpleMessage
    {
        [BsonId()]
        public BsonObjectId Id { get; }

        [BsonElement("FormId")]
        [BsonRequired()]
        public string FormId { get; }


        [BsonElement("User")]
        [BsonRequired()]
        public string User { get; }

        [BsonElement("Text")]
        [BsonRequired()]
        public string Text { get; }

        public SimpleMessage(string formId, string username, string text)
        {
            Id = new BsonObjectId(ObjectId.GenerateNewId()); 
            FormId = formId;
            User = username;
            Text = text;
        }
    }
}
