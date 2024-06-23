using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace LeaveManagementSystem1.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "52fe10d8-e6fd-4a20-b5f7-bbb50706460d",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "f005f94a-063c-4b74-9138-8fba955c43eb",
                    Name = "Administrator",
                    NormalizedName = "Administrator"
                },
                new IdentityRole
                {
                    Id = "d51444a6-984f-4d63-8d59-68106b8406a1",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                });

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "8ea6586a-5398-4651-bc04-1129f8d75593",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(1998, 09, 14)
            });

            builder.Entity<IdentityUserRole<string>>().HasData
                (new IdentityUserRole<string> 
                
                {
                  RoleId = "f005f94a-063c-4b74-9138-8fba955c43eb",
                  UserId = "8ea6586a-5398-4651-bc04-1129f8d75593"

                });


        }
            
        public DbSet<LeaveType>LeaveTypes { get; set; }
    }
}
