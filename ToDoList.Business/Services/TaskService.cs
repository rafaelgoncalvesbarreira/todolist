using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Business.Contract.Infra;
using ToDoList.Business.Contract.Services;
using ToDoList.Model;

namespace ToDoList.Business.Contracts.Services
{
    public class TaskService: ITaskService
    {
        private readonly IRepository repository;
        public TaskService(IRepository _repository)
        {
            repository = _repository;
        }

        public void Create(Task task)
        {
            repository.Add<Task>(task);
            repository.Save();
        }
    }
}
