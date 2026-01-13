using AutoMapper;
using Models_ConferenceHallManagement.AppDbModels;
using Web_ConferenceHallManagement.Models;

namespace Web_ConferenceHallManagement.MappingUtility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MasterCHBookingStatusVM, MasterBookingStatusCode>().ReverseMap();
            CreateMap<MasterCHRoomTypeVM, MasterRoomType>().ReverseMap();
            CreateMap<ConferenceHallVM, ConferenceHall>().ReverseMap();
            CreateMap<ConferenceHallSessionVM, ConferenceHallSession>().ReverseMap();
            CreateMap<ConferenceHallBookingVM, ConferenceHallBooking>().ReverseMap();
        }
    }
}
