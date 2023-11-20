using MovieAPI.Entities.Models.Entities;
using MovieAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.DAL.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        T GetWhere(Expression<Func<T, bool>> exp);
        List<T> GetWhereAll(Expression<Func<T, bool>> exp);
        List<T> GetIncluded(Expression<Func<T, bool>> exp);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
        int Save();

    }
}
