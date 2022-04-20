using AutoMapper;
using HotelApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace HotelApi.Services
{
    public class DefaultRoomService : IRoomService
    {
        private readonly HotelApiDbContext _context;
        private readonly IMapper _mapper;
        public DefaultRoomService(
            HotelApiDbContext context, 
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Room> GetRoomAsync(Guid roomId)
        {
            var entity = await _context.Rooms.SingleOrDefaultAsync(r => r.Id == roomId);

            if (entity == null)
            {
                return null;
            }

            return _mapper.Map<Room>(entity);
        }
    }
}
