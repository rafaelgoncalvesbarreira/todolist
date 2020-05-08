using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Business.Contract.Infra;
using ToDoList.Business.Contract.Services;
using ToDoList.Model;

namespace ToDoList.Business.Contracts.Services
{
    public class TaskService: ITaskService
    {
        private readonly IRepository _repository;
        public TaskService(IRepository repository)
        {
            _repository = repository;
        }

        public void Create(TaskToDo task)
        {
            task.Status = StatusEnum.Awaiting;
            _repository.Add<TaskToDo>(task);
            _repository.Save();
        }

        public IQueryable<TaskToDo> GetAll()
        {
            return _repository.GetAll<TaskToDo>();
        }

        public TaskToDo GetByID(int id)
        {
            var taskToDo = _repository.GetAll<TaskToDo>().FirstOrDefault(t => t.Id == id);
            return taskToDo;
        }
    }
}
