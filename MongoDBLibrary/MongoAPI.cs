using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace MongoDBLibrary
{
    public class MongoAPI
    {
        private static string ConnectionString = "mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false";
        private readonly IMongoDatabase db;

        public MongoAPI(string database)
        {
            var client = new MongoClient(ConnectionString);
            db = client.GetDatabase(database);
        }

        #region Create

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        #endregion

        #region Read

        public List<T> LoadRecord<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument() { }).Sort("{_id:-1}").ToList();
        }

        public List<T> LoadRecordByUID<T>(string table, string uid)
        {
            var collection = db.GetCollection<T>(table);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("uid", uid);
            return collection.Find(filter).ToList();
        }

        #endregion

    }
}
