using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Business.Contract.Infra
{
    public interface IRepository
    {
        public void Add<TEntity>(TEntity entity);
        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        public void Update<TEntity>(TEntity entity) where TEntity : class;
        public void Delete<TEntity>(TEntity entity) where TEntity : class;
        public void Save();
        public Task SaveAsync();
    }
}
