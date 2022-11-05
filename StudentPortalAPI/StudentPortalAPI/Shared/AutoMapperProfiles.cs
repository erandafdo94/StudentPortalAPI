using AutoMapper;
using StudentPortalAPI.DataModels;
using StudentPortalAPI.Dto;

namespace StudentPortalAPI.Shared
{
    public class AutoMapperProfiles : Profile 
    {
        public AutoMapperProfiles()
        {
            CreateMap<StudentDto, Student>()
                .ReverseMap();

            CreateMap<GenderDto, Gender>()
                .ReverseMap();

            CreateMap<AddressDto, Address>()
                .ReverseMap();

        }
    }
}
