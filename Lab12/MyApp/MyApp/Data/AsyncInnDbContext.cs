using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Amenity> Amenities { get; set; }


        public AsyncInnDbContext(DbContextOptions options) : base(options)
        {

        }

        //This function is reponsible for the data seeding!
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(

                new Hotel { Id = 1, Name = "Holiday", Country = "Jordan", City = "Amman", State = "Amman", StreetAddress = "Rainbow street", Phone = 0777102030 },
                new Hotel { Id = 2, Name = "Happy", Country = "Jordan", City = "Amman", State = "Amman", StreetAddress = "Press street", Phone = 0777102031 },
                    new Hotel { Id = 3, Name = "Ahlan", Country = "Jordan", City = "Amman", State = "Amman", StreetAddress = "City street", Phone = 0777102032 }

                );


            modelBuilder.Entity<Room>().HasData(

                new Room { Id = 1, Name = "Rainbow" },
                new Room { Id = 2, Name = "Royal" },
                new Room { Id = 3, Name = "Suite" }

                );



            modelBuilder.Entity<Amenity>().HasData(

                new Amenity { Id = 1, Name = "AC" },
                new Amenity { Id = 2, Name = "TV" },
                new Amenity { Id = 3, Name = "Microwave" }

                );
        }


    }
}
