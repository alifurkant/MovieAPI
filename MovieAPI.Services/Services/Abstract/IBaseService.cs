using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.BLL.Services.Abstract
{
    public interface IBaseService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T GetWhere(Expression<Func<T, bool>> exp);
        List<T> GetWhereAll(Expression<Func<T, bool>> exp);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
