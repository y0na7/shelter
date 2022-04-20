using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Shelter.Shared.Models
{
    public class ShelterItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? MongoId { get; set; }

        [BsonElement("type")]
        public string Navn { get; set; }


        [BsonElement("properties.beskrivels")]
        public string Beskrivelse { get; set; }


        [BsonElement("properties.antal_pl")] //properties.x
        public int AntalPladser { get; set; }

       /* public ShelterItem(string navn = "shelter", string beskrivelse = "hej", int antalpladser = 1)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
            AntalPladser = antalpladser;
        }*/
       public ShelterItem()
        {

        }
    }
}
