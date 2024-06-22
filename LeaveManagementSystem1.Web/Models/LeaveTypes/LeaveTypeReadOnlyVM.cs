﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem1.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
    
   
}
