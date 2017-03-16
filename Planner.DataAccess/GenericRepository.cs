using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.DataAccess
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbContext _context;
        private DbSet<TEntity> _set;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _set = _context.Set<TEntity>();
        }

        public void Create(TEntity item)
        {
            _set.Add(item);
        }

        public void Delete(TEntity item)
        {
            _set.Remove(item);
        }

        public IEnumerable<TEntity> Read()
        {
            return _set.AsNoTracking().ToList();
        }

        public TEntity Read(int id)
        {
            return _set.Find(id);
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
