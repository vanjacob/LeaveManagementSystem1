using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem1.Web.Data.Configurations
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "41860a17-9ca8-4ad9-bad0-f6a2e8e8dc59",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "1059ada4-3252-4c14-b00f-bf32c73ea482",
                    Name = "Administrator",
                    NormalizedName = "Administrator"
                },
                new IdentityRole
                {
                    Id = "94ed9338-1062-40b4-8667-2f622a1f789a",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                });
        }
    }
}
