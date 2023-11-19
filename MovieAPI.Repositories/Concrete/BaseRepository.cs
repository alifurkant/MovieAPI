using Microsoft.EntityFrameworkCore;
using MovieAPI.Entities.Context;
using MovieAPI.Entities.Models.Entities;
using MovieAPI.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Repositories.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext context;

        public BaseRepository(AppDbContext context)
        {
            this.context = context;
        }
        public bool Add(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.IsActive = true;
            context.Set<T>().Add(entity);
            return Save() > 0;
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            entity.IsActive=false;
            entity.DeletedDate = DateTime.Now;
            context.Set<T>().Update(entity);
            return Save() > 0;
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().FirstOrDefault(context=>context.Id == id);
        }

        public T GetWhere(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetWhereAll(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().Where(exp).ToList();
        }

        public List<T> GetIncluded(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().Include(exp).ToList();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
