using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        ITaskService taskService;

        public TasksController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return taskService.Get();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Task Get(string id)
        {
            return taskService.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public Task Post([FromBody]Task task)
        {
            return taskService.Create(task);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Task task)
        {
            taskService.Update(id, task);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            taskService.Remove(id);
        }
    }
}
