using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem1.Web.Data
{
    public class LeaveType : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;
        public int NumberOfDays { get; set; }

        public List<LeaveAllocation>? LeaveAllocations { get; set; }
    }
}
