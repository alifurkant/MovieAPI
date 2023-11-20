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
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private readonly AppDbContext context;
        public MovieRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

    }
}
