using MongoDB.Driver;
using MongoDB.Bson;
using Shelter.Shared.Models;
using System;

namespace Shelter.Server.Models
{
   /* public class BookingDBContext
    {

        private readonly IMongoDatabase mongoDatabase;
        public BookingDBContext()
        {
            string atlasConnection = "mongodb+srv://Jonas:admin@sheltercluster.gp6j5.mongodb.net/test";

            var client = new MongoClient(atlasConnection);

            mongoDatabase = client.GetDatabase("Shelterdb");
        }
        public IMongoCollection<BookingItem> Booking
        {
            get
            {
                return
                mongoDatabase.GetCollection<BookingItem>("Booking");
            }
        }
    }*/
}