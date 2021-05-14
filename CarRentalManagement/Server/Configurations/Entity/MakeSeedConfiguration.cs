using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure (EntityTypeBuilder<Make> builder)
        {
            builder.HasData (
                new Make { Id = 1 , Name = "BMW" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Make { Id = 2 , Name = "FORD" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Make { Id = 3 , Name = "FERRARI" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Make { Id = 4 , Name = "TOYOTA" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Make { Id = 5 , Name = "SAYPA" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now });
        }
    }
}
