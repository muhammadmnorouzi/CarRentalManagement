using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
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

        public UnitOfWork (ApplicationDbContext context )
        {
            this.context = context;
        }

        public IGenericRepository<Make> Makes => makes ??= new GenericRepository<Make>(context);

        public void Dispose ( )
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save ( )
        {
            await context.SaveChangesAsync();
        }
    }
}
