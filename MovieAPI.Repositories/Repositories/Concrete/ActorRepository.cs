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
    public class ActorRepository : BaseRepository<Actor>, IActorRepository
    {
        private readonly AppDbContext context;

        public ActorRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public bool AddMovieToActor(int movieId, int ActorId)
        {
            Movie movie = context.Movies.FirstOrDefault(x=>x.Id == movieId);
            Actor actor = context.Actors.FirstOrDefault(x => x.Id == ActorId);
            if (movie != null && actor!=null)
            {
                movie.Actors.Add(actor);
            }
            
            return context.SaveChanges() > 0;
        }

        public List<Actor> GetActorsIncludedMovies()
        {
            return context.Actors.Include(x=> x.Movies).ToList();
        }
    }
}
