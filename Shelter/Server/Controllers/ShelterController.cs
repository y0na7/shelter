using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shelter.Server.Models;
using Shelter.Shared;
using Shelter.Shared.Models;
using System.Net;

namespace Shelter.Server.Controllers
{
    [Route("api/shelter")]
    [ApiController]
    public class ShelterController : ControllerBase
    {
        private readonly IShelterRepository Repository = new ShelterRepositoryMongo();


        public ShelterController(IShelterRepository shelterRepository)
        {
            if (Repository == null && shelterRepository != null)
            {
                Repository = shelterRepository;
                Console.WriteLine("Repository initialized");
            }
        }

        [HttpGet]
        public IEnumerable<ShelterItem> GetAllItems()
        {
            return Repository.GetAllItems();
        }
        /*[HttpGet]
        [ActionName("actionname2")]
        public IEnumerable<BookingItem> GetAllItems2()
        {
            return Repository.GetAllItems2();
        }*/

        /*[HttpDelete("{id:int}")]
        public StatusCodeResult DeleteItem(int id)
        {
            Console.WriteLine("Server: Delete item called: id = " +id);

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
        }*/

       /*[HttpGet("{id:int}")]
        public ShelterItem FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }*/
    }
}