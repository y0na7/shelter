using MongoDB.Driver;
using MongoDB.Bson;
using Shelter.Shared.Models;

namespace Shelter.Server.Models
{
    public class ShelterDBContext
    {
        private readonly IMongoDatabase mongoDatabase;
        public ShelterDBContext()
        {
            string atlasConnection = "mongodb+srv://Jonas:admin@sheltercluster.gp6j5.mongodb.net/test";

            var client = new MongoClient(atlasConnection);

            mongoDatabase = client.GetDatabase("Shelterdb");
        }
        public IMongoCollection<ShelterItem> Items
        {
            get
            {
                return
                mongoDatabase.GetCollection<ShelterItem>("Items");
            }
        }
    }
}
