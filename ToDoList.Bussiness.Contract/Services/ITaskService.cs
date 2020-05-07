using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Model;

namespace ToDoList.Business.Contract.Services
{
    public interface ITaskService
    {
        public void Create(TaskToDo task);
    }
}
