using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.DataAccess
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        TEntity Read(int id);
        IEnumerable<TEntity> Read();
        void Update(TEntity item);
        void Delete(TEntity item);
    }
}
