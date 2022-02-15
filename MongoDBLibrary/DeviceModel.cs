using MongoDB.Bson;

namespace MongoDBLibrary
{
    public class DeviceModel
    {
        public ObjectId _id { get; set; }
        public string uid { get; set; }
        public string deviceName { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        //public DateTime Timestamp { get; set; }
    }
}