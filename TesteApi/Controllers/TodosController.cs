using Microsoft.AspNetCore.Mvc;
using Teste.Domain.Entities;
using Teste.Infra.Services;

namespace TesteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ConsultaTodoService _todoService;

        //public TodosController(ConsultaTodoService todoService)
        //{
        //    _todoService = todoService;
        //}

        [HttpGet("todo")]
        public Todo Get()
        {
            ConsultaTodoService todoService = new();
            return todoService.RetornaTodo();
            //return _todoService.RetornaTodo();
        }

        [HttpGet("todos")]
        public IEnumerable<Todo> GetTodos()
        {
            ConsultaTodoService todoService = new();
            return todoService.RetornaTodos();
            //return _todoService.RetornaTodos();
        }
    }
}
