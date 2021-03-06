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

        public List<T> LoadAllRecords<T>(string table)
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

        public List<T> LoadAccountCredentials<T>(string table, string userName)
        {
            var collection = db.GetCollection<T>(table);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("userName", userName);
            return collection.Find(filter).ToList();
        }

        public List<T> LoadRecordByUsername<T>(string table, string username)
        {
            var collection = db.GetCollection<T>(table);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("userName", username);
            return collection.Find(filter).ToList();
        }

        public List<T> LoadDeviceByDeviceName<T>(string table, string deviceName)
        {
            var collection = db.GetCollection<T>(table);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("deviceName", deviceName);
            return collection.Find(filter).ToList();
        }

        public List<T> GetPersonIdByDeviceId<T>(string table, ObjectId deviceId)
        {
            var collection = db.GetCollection<T>(table);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("deviceId", deviceId);
            return collection.Find(filter).ToList();
        }

        public List<T> LoadPersonByPersonId<T>(string table, ObjectId personId)
        {
            var collection = db.GetCollection<T>(table);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("_id", personId);
            return collection.Find(filter).ToList();
        }

        public List<T> LoadDeviceDeviceUID<T>(string table, string uid)
        {
            var collection = db.GetCollection<T>(table);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("uid", uid);
            return collection.Find(filter).ToList();
        }

        public List<T> LoadLocationByUID<T>(string table, string uid)
        {
            var collection = db.GetCollection<T>(table);
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("uid", uid);
            return collection.Find(filter).ToList();
        }

        #endregion

        #region Delete

        public void DeleteRecordByDeviceName<T>(string table, string deviceName)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("deviceName", deviceName);
            collection.DeleteOne(filter);
            }

        #endregion

    }
}
