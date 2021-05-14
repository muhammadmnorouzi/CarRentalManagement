using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure (EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Id = "12408b1c-e0ab-4dd8-ab99-d761b0f1cf31" , Name = "User", NormalizedName = "USER" },
                new IdentityRole { Id = "8fd76e2a-6a76-4254-8de9-72718e7ffb51" , Name = "Administrator", NormalizedName = "ADMINISTRATOR" });
        }
    }
}
