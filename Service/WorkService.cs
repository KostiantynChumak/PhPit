using BlazorMongoDB.Data;
using BlazorMongoDB.IService;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMongoDB.Service
{
    public class WorkService : IWorkService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<Work> _workTable = null;
        public WorkService()
        {
            _mongoClient = new MongoClient("mongodb://127.0.0.1:27017/");
            _database = _mongoClient.GetDatabase("ITDB");
            _workTable = _database.GetCollection<Work>("Work");
        }
        public string Delete(string workId)
        {
            _workTable.DeleteOne(x =>x.Id == workId);
            return "Deleted";
        }

        public Work GetWork(string workId)
        {
            return _workTable.Find(x => x.Id == workId).FirstOrDefault();
        }

        public List<Work> GetWorks()
        {
            return _workTable.Find(FilterDefinition<Work>.Empty).ToList();
        }

        public void SaveOrUpdate(Work work)
        {
            var workObj = _workTable.Find(x => x.Id == work.Id).FirstOrDefault();
            if (workObj == null)
            {
                _workTable.InsertOne(work);
            }
            else
            {
                _workTable.ReplaceOne(x => x.Id == work.Id, work);
            }
        }
    }
}