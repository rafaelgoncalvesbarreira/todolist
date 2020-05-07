using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Business.Contract.Infra;
using ToDoList.Model;

namespace ToDoList.Business.EntityFramework
{
    public class ToDoListDbContext : DbContext, IRepository
    {
        public DbSet<TaskToDo> TaskToDos { get; set; }

        public ToDoListDbContext (DbContextOptions<ToDoListDbContext > options):base(options)
        {
            
        }

        #region IRepository
        void IRepository.Add<TEntity>(TEntity entity)
        {
            this.Add(entity);
        }

        public void Save()
        {
            this.SaveChanges();
        }
        #endregion
    }
}
