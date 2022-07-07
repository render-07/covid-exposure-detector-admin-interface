using MongoDB.Bson;
using System;

namespace MongoDBLibrary
{
    public class InformationModel
    {
        public ObjectId _id { get; set; }
        public string fromWhatDevice { get; set; }
        public string closeContact { get; set; }
        public DateTime date { get; set; }
        public int __v { get; set; }
    }
}
