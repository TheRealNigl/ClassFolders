using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        private readonly ToDoContext _Context;

        public ToDoController(ToDoContext context)
        {
            _Context = context;

            if (_Context.ToDoItems.Count() == 0)
            {
                _Context.ToDoItems.Add(new ToDoItem { name = "Item1" });
                _Context.SaveChanges();
            }
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ToDoItem> GetAll()
        {
            return _Context.ToDoItems.ToList();
        }

        [HttpGet("{id}", Name = "GetToDo")]
        public IActionResult GetById(long id)
        {
            var item = _Context.ToDoItems.FirstOrDefault(t => t.id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Create([FromBody] ToDoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _Context.ToDoItems.Add(item);
            _Context.SaveChanges();

            return CreatedAtRoute("GetToDo", new { id = item.id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] ToDoItem item)
        {
            if (item == null || item.id != id)
            {
                return BadRequest();
            }

            var todo = _Context.ToDoItems.FirstOrDefault(t => t.id == id);
            if(todo == null)
            {
                return NotFound();
            }

            todo.IsComplete = item.IsComplete;
            todo.name = item.name;

            _Context.ToDoItems.Update(todo);
            _Context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _Context.ToDoItems.FirstOrDefault(t => t.id == id);
            if(todo == null)
            {
                return NotFound();
            }

            _Context.ToDoItems.Remove(todo);
            _Context.SaveChanges();
            return new NoContentResult();

        }
    }
}
