using AutoMapper;
using LeaveManagementSystem1.Web.Models.LeaveRequests;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class LeaveRequestAutoMapperProfile : Profile
    {
        public LeaveRequestAutoMapperProfile()
        {
            CreateMap<LeaveRequestCreateVM, LeaveRequest>();
        }
            
    }
}