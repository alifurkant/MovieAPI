using MovieAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.DAL.Repositories.Abstract
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        List<Category> GetCategoriesIncludedMovies();
    }
}
