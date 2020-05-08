using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDoList.Business.Contract.Infra
{
    public interface IRepository
    {
        public void Add<TEntity>(TEntity entity);
        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        public void Update<TEntity>(TEntity entity);
        public void Delete<TEntity>(TEntity entity);
        public void Save();
        public void SaveAsync();
    }
}
