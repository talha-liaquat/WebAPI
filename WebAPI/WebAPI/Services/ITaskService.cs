using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services
{
    public interface ITaskService
    {
        List<Task> Get();
        Task Get(string id);
        Task Create(Task task);
        void Update(string id, Task taskIn);
        void Remove(Task taskIn);
        void Remove(string id);
    }
}
