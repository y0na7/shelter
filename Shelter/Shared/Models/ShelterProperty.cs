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
    public class ShelterProperty
    {
        [BsonElement("navn")]
        public string? Navn { get; set; }
        [BsonElement("beskrivels")]
        public string? Beskrivelse { get; set; }
        [BsonElement("antal_pl")]
        public int AntalPladser { get; set; }
    }
}
