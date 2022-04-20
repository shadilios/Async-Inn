﻿using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace MyApp.Models.Interfaces.Services
{
    public class RoomRepository : IRoom
    {
        private readonly AsyncInnDbContext _context;

        public RoomRepository(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<Room> Create(Room room)
        {
            _context.Entry(room).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> GetRoom(int id)
        {
            Room room = await _context.Rooms.FindAsync(id);

            return room;
        }

        public async Task<List<Room>> GetRooms()
        {
            var rooms = await _context.Rooms.ToListAsync();
            return rooms;
        }

        public async Task<Room> UpdateRoom(int id, Room room)
        {
            _context.Entry(room).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return room;
        }

        public async Task Delete(int id)
        {
            Room room = await GetRoom(id);

            _context.Entry(room).State = EntityState.Deleted;

            await _context.SaveChangesAsync();


        }
    }
}
