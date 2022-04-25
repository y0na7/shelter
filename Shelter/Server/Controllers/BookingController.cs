using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shelter.Server.Models;
using Shelter.Shared;
using Shelter.Shared.Models;
using System.Net;

namespace Booking.Server.Controllers
{
    [Route("api/booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IShelterRepository Repository2 = new ShelterRepositoryMongo();


        public BookingController(IShelterRepository shelterRepository)
        {
            if (Repository2 == null && shelterRepository != null)
            {
                Repository2 = shelterRepository;
                Console.WriteLine("Repository initialized");
            }
        }

        [HttpGet]
        public IEnumerable<BookingItem> GetAllItems2()
        {
            return Repository2.GetAllItems2();
        }
        [HttpPost]
        public void AddItem(BookingItem TheBooking)
        {
            Console.WriteLine("Add item called: " + TheBooking.ToString());
            Repository2.AddItem(TheBooking);
        }
        /*[HttpGet]
        [ActionName("actionname2")]
        public IEnumerable<BookingItem> GetAllItems2()
        {
            return Repository.GetAllItems2();
        }*/

        /* [HttpDelete("{id:int}")]
         public StatusCodeResult DeleteItem(int id)
         {
             Console.WriteLine("Server: Delete item called: id = " + id);

             bool deleted = Repository.DeleteItem(id);
             if (deleted)
             {
                 Console.WriteLine("Server: Item deleted succces");
                 int code = (int)HttpStatusCode.OK;
                 return new StatusCodeResult(code);
             }
             else
             {
                 Console.WriteLine("Server: Item deleted fail - not found");
                 int code = (int)HttpStatusCode.NotFound;
                 return new StatusCodeResult(code);
             }
         } */



        /*[HttpGet("{id:int}")]
        public BookingItem FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }*/
    }
}