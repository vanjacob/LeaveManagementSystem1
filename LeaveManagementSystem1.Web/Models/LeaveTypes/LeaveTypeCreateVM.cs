using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem1.Web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM    
    
    {
        [Required]
        [Length(6, 150, ErrorMessage = "Please enter 4 to 150 characters only.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1,90)]
        [Display(Name = "Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
}
