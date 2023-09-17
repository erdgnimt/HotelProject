using AutoMapper;
using HotelProject.DTO.DTO.AppUserDTO;
using HotelProject.DTO.DTO.RoomDTO;
using HotelProject.Entity.Concrete;

namespace HotelProject.WebAPI.Mapping
{
    public class MappingDTO : Profile
    {
        public MappingDTO()
        {
            CreateMap<RoomAddDTO, Room>().ReverseMap();
            CreateMap<RoomUpdateDTO, Room>().ReverseMap();

            CreateMap<AppUserWorkLocationDTO,AppUser>().ReverseMap();
        }

    }
}
