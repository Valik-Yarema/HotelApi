﻿using HotelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelApi
{
    public class HotelApiDbContext : DbContext
    {
        public HotelApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RoomEntity> Rooms { get; set; }
    }
}