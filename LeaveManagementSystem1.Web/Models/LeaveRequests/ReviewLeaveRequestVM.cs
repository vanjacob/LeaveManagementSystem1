using LeaveManagementSystem1.Web.Models.LeaveAllocations;
using System.ComponentModel;

namespace LeaveManagementSystem1.Web.Models.LeaveRequests.cs
{
    public class ReviewLeaveRequestVM : LeaveRequestReadOnlyVM
    

        {
            public EmployeeListVM Employee { get; set; } = new EmployeeListVM();

            [DisplayName("Additional Information")]
            public string? RequestComments { get; set; }
        }
    
}