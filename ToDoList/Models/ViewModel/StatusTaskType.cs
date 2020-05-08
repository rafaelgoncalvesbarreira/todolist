using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Model;

namespace ToDoList.Mvc.Models.ViewModel
{
    public class StatusTaskType: EnumerationBase
    {
        public static readonly StatusTaskType AWAITING = new StatusTaskType((int)StatusEnum.Awaiting, "Awaiting");
        public static readonly StatusTaskType DOING = new StatusTaskType((int)StatusEnum.Doing, "Doing");
        public static readonly StatusTaskType DONE = new StatusTaskType((int)StatusEnum.Done, "Done");

        public StatusTaskType(int id, string description):base(id, description)
        {

        }
    }
}
