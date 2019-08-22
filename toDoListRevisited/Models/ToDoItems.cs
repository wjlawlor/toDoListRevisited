using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace toDoListRevisited.Models
{
    public class ToDoItem
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}