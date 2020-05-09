using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Business.Contract.Infra;
using ToDoList.Business.Contracts.Services;
using Xunit;
using NSubstitute;
using ToDoList.Model;

namespace ToDoList.Business.Test.Services
{
    public class TaskServiceTests
    {
        private TaskService _service;
        private IRepository _mockRepository;
        public TaskServiceTests()
        {
            _mockRepository = Substitute.For<IRepository>();

            _service = new TaskService(_mockRepository);
        }
        [Fact]
        public void CreateTaskTodoTest()
        {
            var task = new TaskToDo
            {
                Title = "Title",
                Description = "Description",
                Status = StatusEnum.Awaiting
            };

            _service.Create(task);

            _mockRepository.ReceivedWithAnyArgs().Add<TaskToDo>(default);
            _mockRepository.Received().Save();
        }
    }
}
