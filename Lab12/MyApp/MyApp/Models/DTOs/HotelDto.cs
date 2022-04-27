using System.Collections.Generic;

namespace MyApp.Models.DTOs
{
    public class HotelDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Phone { get; set; }
        
        public List<RoomDto> Rooms { get; set; }
    }
}
