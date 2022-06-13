using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_DataAccessLayer.Interface;
using Todo_DataAccessLayer.Models;

namespace Todo_BusinessLayer
{
    public class TodoService
    {
        public readonly ITodo _todo;
       

        public TodoService(ITodo todo)
        {
            _todo = todo;
           
        }
       

        public async Task<Todo> CreateTask(Todo todo)
        {

            return await _todo.Create(todo);
        }
    }
}
