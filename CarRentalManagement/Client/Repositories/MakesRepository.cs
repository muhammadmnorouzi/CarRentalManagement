using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagement.Client.IRepositories;
using CarRentalManagement.Shared.Domain;

namespace CarRentalManagement.Client.Repositories
{
    public class MakesRepository : IBaseRepository<Make>
    {
        public Task<Make> Add (Make entity) => throw new NotImplementedException ();
        public Task Delete (int id) => throw new NotImplementedException ();
        public Task<Make> Get (int id) => throw new NotImplementedException ();
        public Task<IEnumerable<Make>> GetAll ( ) => throw new NotImplementedException ();
        public Task Update (Make entity) => throw new NotImplementedException ();
    }
}
