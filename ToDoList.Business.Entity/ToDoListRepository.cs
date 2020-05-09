using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Business.Contract.Infra;

namespace ToDoList.Business.EntityFramework
{
    public class ToDoListRepository: IRepository
    {
        private readonly ToDoListDbContext _context;
        public ToDoListRepository(ToDoListDbContext context)
        {
            _context = context;
        }
        #region IRepository
        public void Add<TEntity>(TEntity entity)
        {
            _context.Add(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Set<TEntity>().Update(entity);
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task SaveAsync()
        {
             await _context.SaveChangesAsync();
        }

        #endregion
    }
}
