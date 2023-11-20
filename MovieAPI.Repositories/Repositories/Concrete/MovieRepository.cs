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
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private readonly AppDbContext context;
        public MovieRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public bool AddActorToMovie(int actorId, int MovieId)
        {
            Movie movie = context.Movies.FirstOrDefault(x => x.Id == MovieId);
            Actor actor = context.Actors.FirstOrDefault(x => x.Id == actorId);
            if (movie != null && actor != null)
            {
                movie.Actors.Add(actor);
            }

            return context.SaveChanges() > 0;
        }

        public List<Movie> GetMoviesIncludedActorsCategories()
        {
            return context.Movies.Include(x => x.Actors).Include(x=>x.Category).ToList();
        }
    }
}
