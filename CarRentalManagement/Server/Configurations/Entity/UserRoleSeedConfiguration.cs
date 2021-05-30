using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure (EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "8fd76e2a-6a76-4254-8de9-72718e7ffb51" ,
                UserId = "161d7fad-fce9-48b4-a31b-369f56d0b1a5"
            });
        }
    }
}
