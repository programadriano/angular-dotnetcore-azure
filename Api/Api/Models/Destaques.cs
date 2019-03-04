using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Destaques
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string editoria { get; set; }
        public string title { get; set; }
        public string link_banner { get; set; }
        public string description { get; set; }
        public string url_image_banner { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
        public Int32 __v { get; set; }
    }
}
