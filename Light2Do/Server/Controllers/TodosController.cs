using Light2Do.Server.Domain;
using Light2Do.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Light2Do.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : Controller
    {
        private readonly DataManager dataManager;

        public TodosController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        [HttpPost]
        public IActionResult Add (TodoItems todoItem)
        {
            dataManager.Todos.Add(todoItem);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var todoslist = dataManager.Todos.Get();
            return Ok(todoslist);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            dataManager.Todos.Delete(id);
            return Ok();
        }
    }
}
