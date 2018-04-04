using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoMvcNew.Models;
using TodoMvcNew.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TodoMvcNew.Services
{
    public class TodoItemService : ITodoItemService
    {
        //private readonly ApplicationDbContext _context;

        /*public TodoItemService(ApplicationDbContext context){
            _context = context;
        }*/
        public async Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync(){
            //return await _context.Items.Where(x => x.IsDone == false).ToArrayAsync();
            return null;
        }
    }
}