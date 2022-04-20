using AutoMapper;
using HotelApi.Models;

namespace HotelApi.Infrastructure
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<RoomEntity, Room>()
                .ForMember(dest => dest.Rate, otp => otp.MapFrom(src => src.Rate / 100.0m));
            //TODO url.Link
        }
    }
}
