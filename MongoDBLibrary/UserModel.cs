using MongoDB.Bson;
using System;

namespace MongoDBLibrary
{
    public class UserModel
    {
        public ObjectId _id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string address { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        //public DateTime Timestamp { get; set; }
    }
}