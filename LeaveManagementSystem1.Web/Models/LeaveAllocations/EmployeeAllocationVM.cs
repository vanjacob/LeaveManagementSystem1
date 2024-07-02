﻿using LeaveManagementSystem1.Web.Models.LeaveAllocations;


namespace LeaveManagementSystem1.Web.Models.LeaveAllocations;

public class EmployeeAllocationVM : EmployeeListVM
{
    [Display(Name = "Date of Birth")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    [DataType(DataType.Date)]
    public DateOnly DateOfBirth { get; set; }
    public bool IsCompletedAllocation { get; set; }
    public List<LeaveAllocationVM> LeaveAllocations { get; set; } = new List<LeaveAllocationVM>();
}