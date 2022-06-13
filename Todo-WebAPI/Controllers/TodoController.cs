
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo_BusinessLayer;
using Todo_DataAccessLayer.Models;

namespace Todo_WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        public readonly TodoService _todoService;
        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpPost("AddTask")]
        public async Task<Object> CreateNewTask([FromBody] Todo todo)
        {
            try
            {
                return Ok(await _todoService.CreateTask(todo));
            }
            catch(Exception ex)
            {
                throw ex; 
              
            }
        }
    }
}
