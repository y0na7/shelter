using Shelter.Shared.Models;
using System.Net.Http.Json;

namespace Shelter.Client.Services
{
    public class ShelterService : IShelterService
    {
        private readonly HttpClient httpClient;

        public ShelterService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ShelterItem[]?> GetAllItems()
        {
            var result = await httpClient.GetFromJsonAsync<ShelterItem[]>("api/shelter");
            return result;
        }
        public async Task<int> AddItem(ShelterItem item)
        {
            var response = await httpClient.PostAsJsonAsync("api/shelter", item);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        /*public async Task<ShelterItem> GetItem(int id)
        {
            var result = await httpClient.GetFromJsonAsync<ShelterItem>("api/shelter/" + id);
            return result;
        }*/

        public void UpdateItem(ShelterItem item)
        {
            throw new NotImplementedException();
        }

        /*public async Task<int> DeleteItem(ShelterItem item)
        {
            throw new NotImplementedException();
        }

        bool IShelterService.DeleteItem(ShelterItem item)
        {
            throw new NotImplementedException();
        }*/

        public void updateItem(ShelterItem item)
        {
            throw new NotImplementedException();
        }
    }
}
