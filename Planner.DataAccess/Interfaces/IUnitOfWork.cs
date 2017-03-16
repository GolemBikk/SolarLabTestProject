using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<MyTask> MyTaskRepository { get; }
        void Save();
    }
}
