using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<T> db;

        public GenericRepository (ApplicationDbContext context)
        {
            this.context = context;
            db = context.Set<T> ();
        }

        public async Task Delete (int id)
        {
            var record = await db.FindAsync (id);
            db.Remove (record);
        }

        public void DeleteRange (IEnumerable<T> entities)
        {
            db.RemoveRange (entities);
        }

        public async Task<T> Get (Expression<Func<T , bool>> expression , List<string> includes = null)
        {
            IQueryable<T> query = db;

            if (includes is not null)
            {
                foreach (var prop in includes)
                {
                    query = query.Include (prop);
                }
            }

            return await query.AsNoTracking ().FirstOrDefaultAsync (expression);
        }

        public async Task<IList<T>> GetAll 
            (Expression<Func<T , bool>> expression = null ,
            Func<IQueryable<T> , IOrderedQueryable<T>> orderBy = null ,
            List<string> includes = null)
        {
            IQueryable<T> query = db;

            if(expression is not null)
            {
                query = query.Where(expression);
            }

            if(includes is not null)
            {
                foreach(var prop in includes)
                {
                    query = query.Include(prop);
                }
            }

            if(orderBy is not null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert (T entity)
        {
            await db.AddAsync (entity);
        }

        public async Task InsertRange (IEnumerable<T> entities)
        {
            await db.AddRangeAsync (entities);
        }

        public void Update (T entity)
        {
            db.Attach (entity);
            context.Entry (entity).State = EntityState.Modified;
        }
    }
}
