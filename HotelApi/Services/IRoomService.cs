using HotelApi.Models;
using System;
using System.Threading.Tasks;

namespace HotelApi.Services
{
    public interface IRoomService
    {
        Task<Room> GetRoomAsync(Guid roomId); 
    }
}
