using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMongoCollection<Task> tasks;

        public TaskService(IConfiguration config)
        {
            if (config == null)
                throw new ArgumentNullException("No configuration injected");

            var client = new MongoClient(config.GetConnectionString("LocalMongoDB"));
            var database = client.GetDatabase("Tododb");
            tasks = database.GetCollection<Task>("tasks");
        }

        public Task Create(Task task)
        {
            tasks.InsertOne(task);
            return task;
        }

        public List<Task> Get()
        {
            return tasks.Find(task => true).ToList();
        }

        public Task Get(string id)
        {
            return tasks.Find<Task>(task => task.Id == id).FirstOrDefault();
        }

        public void Remove(Task taskIn)
        {
            tasks.DeleteOne(task => task.Id == taskIn.Id);
        }

        public void Remove(string id)
        {
            tasks.DeleteOne(task => task.Id == id);
        }

        public void Update(string id, Task taskIn)
        {
            tasks.ReplaceOne(task => task.Id == id, taskIn);
        }
    }
}
