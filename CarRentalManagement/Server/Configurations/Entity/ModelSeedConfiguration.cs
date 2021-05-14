using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure (EntityTypeBuilder<Model> builder)
        {
            builder.HasData (
                new Model { Id = 1 , Name = "A" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Model { Id = 2 , Name = "B" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Model { Id = 3 , Name = "C" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Model { Id = 4 , Name = "D" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now } ,
                new Model { Id = 5 , Name = "E" , CreatedBy = "System" , UpdatedBy = "System" , DateCreated = DateTime.Now , DateUpdated = DateTime.Now });
        }
    }
}
