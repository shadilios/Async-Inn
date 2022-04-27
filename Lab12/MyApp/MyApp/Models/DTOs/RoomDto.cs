using System.Collections.Generic;

namespace MyApp.Models.DTOs
{
    public class RoomDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Layout { get; set; }

        public List<AmenityDto> Amenities { get; set; }
    }
}
