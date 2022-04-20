using Shelter.Shared.Models;


namespace Shelter.Client.Services
{
    public interface IShelterService
    {
        Task<ShelterItem[]?> GetAllItems();

        Task<ShelterItem?> GetItem(int id);

        Task<int> AddItem(ShelterItem item);

        bool DeleteItem(ShelterItem item);
        void updateItem(ShelterItem item);
    }
}
