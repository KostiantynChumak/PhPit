using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMongoDB.Data
{
    public class Work
    {
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
        public string Name { get; set; }

        public string Roll { get; set; }

        public string Age { get; set; }

    }
}
