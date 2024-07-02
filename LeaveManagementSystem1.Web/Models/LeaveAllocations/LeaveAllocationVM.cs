using LeaveManagementSystem1.Web.Data;
using LeaveManagementSystem1.Web.Models.LeaveTypes;
using LeaveManagementSystem1.Web.Models.Periods;
using LeaveManagementSystem1.Web.Data;

namespace LeaveManagementSystem1.Web.Models.LeaveAllocations
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        public int Days { get; set; }
        [Display(Name = "Allocation Period")]
        public PeriodVM Period { get; set; } = new PeriodVM();

        public LeaveTypeReadOnlyVM LeaveType { get; set; } = new LeaveTypeReadOnlyVM();
    }
}