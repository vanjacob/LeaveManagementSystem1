using AutoMapper;
using LeaveManagementSystem1.Web.Data;
using LeaveManagementSystem1.Web.Models.LeaveTypes;

namespace LeaveManagementSystem1.Web.MappingProfiles
{
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile() 
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            //.ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.NumberOfDays));
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
            CreateMap<LeaveTypeDeleteVM, LeaveType>().ReverseMap();
        }

    }
}
