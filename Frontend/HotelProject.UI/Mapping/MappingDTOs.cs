using AutoMapper;
using HotelProject.Entity.Concrete;
using HotelProject.UI.DTO.AboutDTO;
using HotelProject.UI.DTO.AppUserDTO;
using HotelProject.UI.DTO.BookingDTO;
using HotelProject.UI.DTO.ContactDTO;
using HotelProject.UI.DTO.GuestDTO;
using HotelProject.UI.DTO.LoginDTO;
using HotelProject.UI.DTO.RegisterDTO;
using HotelProject.UI.DTO.RoomDTO;
using HotelProject.UI.DTO.SendMessageDTO;
using HotelProject.UI.DTO.ServiceDTO;
using HotelProject.UI.DTO.StaffDTO;
using HotelProject.UI.DTO.SubscribeDTO;
using HotelProject.UI.DTO.TestimonialDTO;
using HotelProject.UI.DTO.WorkLocationDTO;

namespace HotelProject.UI.Mapping
{
    public class MappingDTOs:Profile
    {
        public MappingDTOs()
        {
            CreateMap<ServiceResultDTO, Service>().ReverseMap();
            CreateMap<ServiceUpdateDTO, Service>().ReverseMap();
            CreateMap<ServiceAddDTO, Service>().ReverseMap();

            CreateMap<GuestResultDTO, Guest>().ReverseMap();
            CreateMap<GuestUpdateDTO, Guest>().ReverseMap();
            CreateMap<GuestAddDTO, Guest>().ReverseMap();

            CreateMap<ContactAddDTO, Contact>().ReverseMap();
            CreateMap<ContactInboxDTO, Contact>().ReverseMap();
            CreateMap<ReadInboxMessageDetailsDTO, Contact>().ReverseMap();

            CreateMap<SendboxResultDTO, SendMessage>().ReverseMap();
            CreateMap<SendMessageAddDTO, SendMessage>().ReverseMap();

            CreateMap<AddNewUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO,AppUser>().ReverseMap();

            CreateMap<AboutResultDTO, About>().ReverseMap();
            CreateMap<AboutUpdateDTO, About>().ReverseMap();

            CreateMap<RoomResultDTO, Room>().ReverseMap();
            CreateMap<RoomUpdateDTO, Room>().ReverseMap();
            CreateMap<RoomAddDTO, Guest>().ReverseMap();

            CreateMap<TestimonialResultDTO, Testimonial>().ReverseMap();

            CreateMap<StaffResultDTO,Staff>().ReverseMap();

            CreateMap<SubscribeAddDTO,Subscribe>().ReverseMap();

            CreateMap<BookingAddDTO,Booking>().ReverseMap();
            CreateMap<BookingResultDTO,Booking>().ReverseMap();
            CreateMap<ApprovedReservationDTO,Booking>().ReverseMap();

            CreateMap<AppUserResultDTO, AppUser>().ReverseMap();

            CreateMap<WorkLocationAddDTO, WorkLocation>().ReverseMap();
            CreateMap<WorkLocationResultDTO, WorkLocation>().ReverseMap();
            CreateMap<WorkLocationUpdateDTO, WorkLocation>().ReverseMap();
        }
    }
}
