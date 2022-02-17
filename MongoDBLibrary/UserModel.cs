using MongoDB.Bson;

namespace MongoDBLibrary
{
    public class UserModel
    {
        public ObjectId _id { get; set; }
        public string uid { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        //public DateTime Timestamp { get; set; }
    }
}