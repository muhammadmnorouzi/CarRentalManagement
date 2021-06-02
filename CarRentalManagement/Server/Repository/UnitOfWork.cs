using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        private IGenericRepository<Make> makes;
        private IGenericRepository<Model> models;
        private IGenericRepository<Vehicle> vehicles;
        private IGenericRepository<Booking> booking;
        private IGenericRepository<Customer> customers;
        private IGenericRepository<Colour> colours;

        public UnitOfWork (ApplicationDbContext context)
        {
            this.context = context;
        }

        public IGenericRepository<Make> Makes
            => makes ??= new GenericRepository<Make> (context);

        public IGenericRepository<Model> Models
            => models ??= new GenericRepository<Model> (context);

        public IGenericRepository<Vehicle> Vehicles
            => new GenericRepository<Vehicle> (context);

        public IGenericRepository<Booking> Bookings
            => new GenericRepository<Booking> (context);

        public IGenericRepository<Customer> Customers
            => new GenericRepository<Customer> (context);

        public IGenericRepository<Colour> Colours
            => new GenericRepository<Colour> (context);

        public void Dispose ( )
        {
            context.Dispose ();
            GC.SuppressFinalize (this);
        }

        public async Task Save (HttpContext httpContext)
        {
            var userName = httpContext.User.Identity.Name ?? "Anonymous User";

            var entries = context.ChangeTracker.Entries ()
                    .Where (e => e.State is EntityState.Added or EntityState.Modified);

            foreach (var entry in entries)
            {
                ( (BaseDomainModel) entry.Entity ).DateUpdated = DateTime.Now;
                ( (BaseDomainModel) entry.Entity ).UpdatedBy = userName;

                if (entry.State is EntityState.Added)
                {
                    ( (BaseDomainModel) entry.Entity ).DateCreated = DateTime.Now;
                    ( (BaseDomainModel) entry.Entity ).CreatedBy = userName;
                }
            }

            await context.SaveChangesAsync ();
        }
    }
}
