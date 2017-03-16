using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.BusinessLogic
{
    public interface IMyTaskService
    {
        void Add(MyTaskViewModel value);
        void Edit(MyTaskViewModel value);
        MyTaskViewModel Get(int id);
        IEnumerable<MyTaskViewModel> Get();
        void Remove(int id);
        void Dispose();
    }
}
