using LeaveManagementSystem1.Web.Models.LeaveAllocations;

namespace LeaveManagementSystem1.Web.Models.LeaveAllocations
{
    public class LeaveAllocationEditVM : LeaveAllocationVM
    {
        public EmployeeListVM? Employee { get; set; }
    }
}