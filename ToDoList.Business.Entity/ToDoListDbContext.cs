using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Business.Contract.Infra;
using ToDoList.Model;
using System.Linq;

namespace ToDoList.Business.EntityFramework
{
    public class ToDoListDbContext : DbContext
    {
        public DbSet<TaskToDo> TaskToDos { get; set; }

        public ToDoListDbContext():base()
        {

        }
        public ToDoListDbContext (DbContextOptions<ToDoListDbContext > options):base(options)
        {
            
        }

        
    }
}
