﻿using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace MyApp.Models.Interfaces.Services
{
    public class AmenityRepository : IAmenity
    {
        private readonly AsyncInnDbContext _context;

        public AmenityRepository(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<Amenity> Create(Amenity amenity)
        {
            _context.Entry(amenity).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return amenity;
        }

        public async Task<Amenity> GetAmenity(int id)
        {
            Amenity amenity = await _context.Amenities.FindAsync(id);

            return amenity;
        }

        public async Task<List<Amenity>> GetAminities()
        {
            var amenities = await _context.Amenities.ToListAsync();
            return amenities;
        }

        public async Task<Amenity> UpdateAmenity(int id, Amenity amenity)
        {
            _context.Entry(amenity).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return amenity;
        }

        public async Task Delete(int id)
        {
            Amenity amenity = await GetAmenity(id);

            _context.Entry(amenity).State = EntityState.Deleted;

            await _context.SaveChangesAsync();


        }
    }
}
