using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_DataAccessLayer.Models
{
    public class Todo
    {
        [Key]
        public int TodoListId { get; set; }
        public string TodoName { get; set; }
        public string ToDoDescription { get; set; }
    }
}
