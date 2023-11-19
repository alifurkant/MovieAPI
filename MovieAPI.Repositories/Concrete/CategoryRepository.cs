using MovieAPI.Entities.Context;
using MovieAPI.Models.Entities;
using MovieAPI.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Repositories.Concrete
{
    public class CategoryRepository : BaseRepository<Category> , ICategoryRepository
    {
        private readonly AppDbContext context;

        public CategoryRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
