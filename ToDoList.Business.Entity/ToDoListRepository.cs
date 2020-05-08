using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Business.Contract.Infra;

namespace ToDoList.Business.EntityFramework
{
    public class ToDoListRepository: IRepository
    {
        private readonly ToDoListDbContext context;
        public ToDoListRepository()
        {
            context = new ToDoListDbContext();
        }
        #region IRepository
        public void Add<TEntity>(TEntity entity)
        {
            context.Add(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>().AsNoTracking();
        }

        public void Update<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async void SaveAsync()
        {
            context.SaveChangesAsync();
        }
        #endregion
    }
}
