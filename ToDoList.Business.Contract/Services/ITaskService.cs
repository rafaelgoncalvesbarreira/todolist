using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Model;
using System.Linq;

namespace ToDoList.Business.Contract.Services
{
    public interface ITaskService
    {
        public void Create(TaskToDo task);
        public TaskToDo GetByID(int id);
        public IQueryable<TaskToDo> GetAll();
    }
}
