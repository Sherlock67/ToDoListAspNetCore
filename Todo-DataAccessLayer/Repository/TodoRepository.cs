using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_DataAccessLayer.Data;
using Todo_DataAccessLayer.Interface;
using Todo_DataAccessLayer.Models;

namespace Todo_DataAccessLayer.Repository
{
    public class TodoRepository : ITodo
    {
        public readonly ApplicationDbContext _db;

        public TodoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Todo> Create(Todo entity)
        {
            var obj = await _db.todos.AddAsync(entity);
            _db.SaveChanges();
            return obj.Entity;
            
        }

        public void Delete(Todo entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Todo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Todo entity)
        {
            throw new NotImplementedException();
        }
    }
}
