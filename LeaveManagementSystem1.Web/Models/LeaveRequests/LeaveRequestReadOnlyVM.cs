using LeaveManagementSystem1.Web.Services.LeaveRequestService.cs;
using System.ComponentModel;


namespace LeaveManagementSystem1.Web.Models.LeaveRequests.cs
{
        public class LeaveRequestReadOnlyVM 
    {
            public int Id { get; set; }

            [DisplayName("Start Date")]
            public DateOnly StartDate { get; set; }

            [DisplayName("End Date")]
            public DateOnly EndDate { get; set; }

            [DisplayName("Total Days")]
            public int NumberOfDays { get; set; }

            [DisplayName("Leave Type")]
            public string LeaveType { get; set; } = string.Empty;

            [DisplayName("Status")]
            public LeaveRequestStatusEnum LeaveRequestStatus { get; set; }



    }
    
}