using Shelter.Shared.Models;

namespace Shelter.Client.Services
{
    public interface IBookingService
    {
        Task<BookingItem[]?> GetAllItems2();

        //Task<ShelterItem?> GetItem(int id);

        Task<int> AddItem(BookingItem TheBooking);

        // Task<int> DeleteItem(int id);
       // void updateItem(BookingItem TheBooking);
    }
}
