using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBLibrary
{
    public class LinkModel
    {
        public ObjectId _id { get; set; }
        public ObjectId personId { get; set; }
        public ObjectId deviceId { get; set; }
    }
}
