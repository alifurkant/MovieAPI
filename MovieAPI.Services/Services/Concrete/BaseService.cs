using MovieAPI.BLL.Services.Abstract;
using MovieAPI.DAL.Repositories.Abstract;
using MovieAPI.Entities.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.BLL.Services.Concrete
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        public bool Add(T entity)
        {
            if (entity == null) return false;
            else return baseRepository.Add(entity);
        }

        public bool Delete(int id)
        {
            if(id<0) return false;
            else return baseRepository.Delete(id);
        }

        public List<T> GetAll()
        {
            return baseRepository.GetAll();
        }

        public T GetById(int id)
        {
            return baseRepository.GetById(id);
        }

        public T GetWhere(Expression<Func<T, bool>> exp)
        {
            return baseRepository.GetWhere(exp);
        }

        public List<T> GetWhereAll(Expression<Func<T, bool>> exp)
        {
            return baseRepository.GetWhereAll(exp);
        }

        public bool Update(T entity)
        {
            if (entity == null) return false;
            else return baseRepository.Update(entity);
        }
    }
}
