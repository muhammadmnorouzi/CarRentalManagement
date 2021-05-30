using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure (EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "161d7fad-fce9-48b4-a31b-369f56d0b1a5" ,
                    Email = "muhammadmnorouzi@outlook.com",
                    NormalizedEmail= "MUHAMMADMNOROUZI@OUTLOOK.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null , "P@ssword1")
                });
        }
    }
}
