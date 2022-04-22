using Shelter.Shared.Models;


namespace Shelter.Client.Services
{
    public interface IShelterService
    {
        Task<ShelterItem[]?> GetAllItems();

       // Task<ShelterItem?> GetItem(int id);

        //Task<int> AddItem(BookingItem TheBooking);

       // Task<int> DeleteItem(int id);
        void updateItem(ShelterItem item);
    }
}
