using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Model;
using ToDoList.Mvc.Models.ViewModel;

namespace ToDoList.Mvc.Configurations
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Task, TaskViewModel>();
            CreateMap<TaskViewModel, TaskViewModel>();
        }
    }
}
