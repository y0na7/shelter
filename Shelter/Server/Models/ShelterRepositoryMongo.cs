using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Shelter.Shared;
using Shelter.Shared.Models;

namespace Shelter.Server.Models
{
    public class ShelterRepositoryMongo : IShelterRepository
    {
       
            //private static readonly List<ShelterItem> Items;

            // private static readonly List<ShoppingItem> Items;
            ShelterDBContext db = new ShelterDBContext();
            public void AddItem(ShelterItem item)
            {
                db.Items.InsertOne(item);
            }

           public bool DeleteItem(int id)
            {
              /*  FilterDefinition<ShelterItem> item = Builders<ShelterItem>.Filter.Eq("id", id);
                var deletedItem = db.Items.FindOneAndDelete(item);
                if (deletedItem != null)
                    return true;
                else
                    return false; */
              throw new NotImplementedException();
            }


            public bool UpdateItem(ShelterItem item)
            {
                throw new NotImplementedException();
            }


            //return item with id = -1 if not found
         public ShelterItem FindItem(int id)
            {
                /*
              foreach (var item in Items)
                {
                    if (item.Id == id)
                        return item;
                }
                return new ShelterItem(-1);*/
                throw new NotImplementedException();
             
            } 

            public List<ShelterItem> GetAllItems()
            {
                return db.Items.Find(_ => true).ToList();
            }


        

          /*  public static void InsertTestData()
            {
                Items.Add(new ShelterItem(id: 1, "Shelter1", 5));
                Items.Add(new ShelterItem(id: 2, "Shelter2", 10, true));

            }*/

       
    }
}
