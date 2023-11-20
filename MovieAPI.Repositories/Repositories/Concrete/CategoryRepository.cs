using Microsoft.EntityFrameworkCore;
using MovieAPI.DAL.Repositories.Abstract;
using MovieAPI.Entities.Context;
using MovieAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.DAL.Repositories.Concrete
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly AppDbContext context;

        public CategoryRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public List<Category> GetCategoriesIncludedMovies()
        {
            return context.Categories.Include(c => c.Movies).ToList();
        }
    }
}
