using AutoMapper;
using DTOLayer.AnnouncementDTOs;
using DTOLayer.AppUserDTOs;
using DTOLayer.DestinatonDTOs;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Admin.Models;

namespace TraversalCore.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            
            CreateMap<AnnouncementAdd, Announcement>();
            CreateMap<Announcement, AnnouncementAdd>();

            CreateMap<AnnouncementUpdateDto, Announcement>();
            CreateMap<Announcement, AnnouncementUpdateDto>();

            CreateMap<Announcement, AnnouncementListViewModel>();
            CreateMap<AnnouncementListViewModel, Announcement>();


            CreateMap<AppUserRegisterDTO, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTO>();

            CreateMap<AppUserLoginDTO, AppUser>();
            CreateMap<AppUser, AppUserLoginDTO>();

            CreateMap<DestinationListViewModel, Destination>();
            CreateMap<Destination, DestinationListViewModel>();

            CreateMap<DestinationAddDTO, Destination>();
            CreateMap<Destination, DestinationAddDTO>();



        }
    }
}
