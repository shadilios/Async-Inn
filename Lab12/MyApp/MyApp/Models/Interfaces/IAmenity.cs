using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApp.Models.Interfaces
{
    public interface IAmenity
    {
        Task<Amenity> Create(Amenity amenity);
        Task<List<Amenity>> GetAminities();
        Task<Amenity> GetAmenity(int id);
        Task<Amenity> UpdateAmenity(int id, Amenity amenity);
        Task Delete(int id);
    }
}
