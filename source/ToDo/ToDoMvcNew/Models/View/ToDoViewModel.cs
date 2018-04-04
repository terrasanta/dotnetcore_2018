using System.Collections.Generic;

namespace TodoMvcNew.Models.View
{
    public class ToDoViewModel
    {
        public IEnumerable<ToDoItem> Items { get; set; }
        
    }
}