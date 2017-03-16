using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Planner.DataAccess;

namespace Planner.BusinessLogic
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind(typeof(IGenericRepository<MyTask>)).To(typeof(GenericRepository<MyTask>));
            Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));
        }
    }
}
