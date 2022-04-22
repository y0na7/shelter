using Shelter.Shared.Models;
using System.Net.Http.Json;

namespace Shelter.Client.Services
{
    public class BookingService : IBookingService
    {
            private readonly HttpClient httpClient;

            public BookingService(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }
            public async Task<BookingItem[]?> GetAllItems2()
            {
                var result = await httpClient.GetFromJsonAsync<BookingItem[]>("api/booking");
                return result;
            }
            /*public async Task<BookingItem[]?> GetAllItems2()
            {
                var result = await httpClient.GetFromJsonAsync<BookingItem[]>("api/shelter");
                return result;
            }*/
            public async Task<int> AddItem(BookingItem TheBooking)
            {
                var response = await httpClient.PostAsJsonAsync("api/booking", TheBooking);
                var responseStatusCode = response.StatusCode;
                return (int)responseStatusCode;
            }

            /*public void UpdateItem(BookingItem TheBooking)
            {
                throw new NotImplementedException();
            }*/
    }
}
