using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Business.Contract.Infra
{
    public interface IRepository
    {
        public void Add<TEntity>(TEntity entity);
        public void Save();
    }
}
