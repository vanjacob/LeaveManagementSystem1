using LeaveManagementSystem1.Web.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem1.Web.Data
{
    public class LeaveRequestStatus : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}