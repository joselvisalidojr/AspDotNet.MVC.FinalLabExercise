using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data;
using WorkSchedule.Data.Entities;
using WorkSchedule.Data.Exceptions;

namespace WorkSchedule.Data.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IEnumerable<T> FindAll();
        T FindByPrimaryKey(int id);
        T Insert(T entity);
        T Update(T entity);
        T Delete(int id);
        WorkScheduleContext Context { get; set; }
    }
    public abstract class GenericRepository<T> where T : class
    {
        public GenericRepository(WorkScheduleContext context)
        {
            this.Context = context;
        }

        public WorkScheduleContext Context { get; set; }

        public IEnumerable<T> FindAll()
        {
            IQueryable<T> query = this.Context.Set<T>();
            return query.Select(e => e).ToList();
        }

        public T FindByPrimaryKey(int id)
        {
            var entity = this.Context.Find<T>(id);
            if (entity is object)
            {
                this.Context.Entry<T>(entity).State = EntityState.Detached;
                return entity;
            }

            throw new EntityNotFoundException($"Entity with ID [{id}] does not exist.");
        }

        public T Insert(T entity)
        {
            Context.Add<T>(entity);
            return entity;
        }

        public T Update(T entity)
        {
            this.Context.Attach<T>(entity);
            this.Context.Entry<T>(entity).State = EntityState.Modified;
            return entity;
        }

        public T Delete(int id)
        {
            var entity = this.FindByPrimaryKey(id);
            this.Context.Remove<T>(entity);
            return entity;
        }
    }
}
