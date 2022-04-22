using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Shelter.Shared.Models
{
    [BsonIgnoreExtraElements]
    public class BookingItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? MongoId { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }
        public BookingItem(string name = "a")
        {
            Name = name;
            
        }
        public BookingItem()
        {
            
        }




    }

}