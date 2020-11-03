using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodosController
    {
        private readonly IRepository<Todo> repository;
        public TodosController(IRepository<Todo> repository) => this.repository = repository;

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> Get() => this.repository.GetAll().ToList();

        [HttpGet("{id}")]
        public ActionResult<Todo> Get(int id) => this.repository.GetById(id);

        [HttpPost]
        public void CreateTodo([FromBody] Todo todo) => this.repository.Create(todo);

        [HttpPut]
        public void Update([FromBody] Todo todo) => this.repository.Update(todo);

        [HttpPatch("{id}")]
        public void UpdateById(int id, [FromBody] Todo todo) => this.repository.UpdateById(id, todo);

        [HttpDelete("{id}")]
        public void Delete(int id) => this.repository.RemoveById(id);

        [HttpGet("active")]
        public ActionResult<IEnumerable<Todo>> GetOnlyActives() => this.repository.GetAll().Where(t => t.IsDone == false).ToList();

        [HttpGet("done")]
        public ActionResult<IEnumerable<Todo>> GetOnlyDone() => this.repository.GetAll().Where(t => t.IsDone == true).ToList();

    }
}