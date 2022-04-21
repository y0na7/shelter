using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelter.Shared;
using Shelter.Shared.Models;

namespace Shelter.Server.Models
{
    public interface IShelterRepository
    {
        List<ShelterItem> GetAllItems();
        ShelterItem FindItem(int id);
        void AddItem(ShelterItem item);
        bool DeleteItem(int id);
        bool UpdateItem(ShelterItem item);
    }
}
