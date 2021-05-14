using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure (EntityTypeBuilder<Colour> builder)
        {
            builder.HasData (
                new Colour { Id = 1 , Name = "Black" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Colour { Id = 2 , Name = "Blue" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Colour { Id = 3 , Name = "Red" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Colour { Id = 4 , Name = "Golden" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now });
        }
    }
}
