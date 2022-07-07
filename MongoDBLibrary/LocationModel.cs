using System;
using MongoDB.Bson;

namespace MongoDBLibrary
{
    public class LocationModel
    {
        public ObjectId _id { get; set; }
        public string uid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public DateTime date { get; set; }
        public int __v { get; set; }
    }
}
