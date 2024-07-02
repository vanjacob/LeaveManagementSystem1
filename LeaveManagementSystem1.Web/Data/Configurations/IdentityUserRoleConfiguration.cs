using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;

namespace LeaveManagementSystem1.Web.Data.Configurations
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
                (new IdentityUserRole<string>

                {
                    RoleId = "1059ada4-3252-4c14-b00f-bf32c73ea482",
                    UserId = "17eca5b4-47ac-47b5-8e87-b7325ce0daf1"

                });
        }
    }
}
