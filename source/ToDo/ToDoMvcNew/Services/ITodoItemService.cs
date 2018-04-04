using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoMvcNew.Models;

namespace TodoMvcNew.Services
{
    public interface ITodoItemService
    {
        Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync();
    }
}