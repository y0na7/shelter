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
        public string? PersonNavn { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime? Dato1 { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime? Dato2 { get; set; }
        public string? Shelternavn { get; set; }
       
        public string? email { get; set; }


        public BookingItem()
        {
            
        }




    }

}