using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private PlannerDbContext _context = new PlannerDbContext();
        private GenericRepository<MyTask> _myTaskRepository;

        public GenericRepository<MyTask> MyTaskRepository
        {
            get
            {
                if (_myTaskRepository == null)
                {
                    _myTaskRepository = new GenericRepository<MyTask>(_context);
                }
                return _myTaskRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
