using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.DataAccess;

namespace Planner.BusinessLogic
{
    public class MyTaskService : IMyTaskService
    {
        private IUnitOfWork _database;

        public MyTaskService(IUnitOfWork database)
        {
            _database = database;
        }

        public void Add(MyTaskViewModel value)
        {
            _database.MyTaskRepository.Create(new MyTask {
                Name = value.Name,
                Description = value.Description,
                Date = value.Date,
                Status = false
            });
            _database.Save();
        }      

        public void Edit(MyTaskViewModel value)
        {
            _database.MyTaskRepository.Update(new MyTask
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                Date = value.Date,
                Status = value.Status
            });
            _database.Save();
        }

        public IEnumerable<MyTaskViewModel> Get()
        {
            return _database.MyTaskRepository.Read().Select( x => new MyTaskViewModel {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Date = x.Date,
                Status = x.Status
            });
        }

        public MyTaskViewModel Get(int id)
        {
            var result = _database.MyTaskRepository.Read(id);
            return new MyTaskViewModel {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description,
                Date = result.Date,
                Status = result.Status
            };
        }

        public void Remove(int id)
        {
            MyTask myTask = _database.MyTaskRepository.Read(id);
            if (myTask != null)
            {
                _database.MyTaskRepository.Delete(myTask);
                _database.Save();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
