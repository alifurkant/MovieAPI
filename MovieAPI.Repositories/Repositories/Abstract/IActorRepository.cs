using MovieAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.DAL.Repositories.Abstract
{
    public interface IActorRepository : IBaseRepository<Actor>
    {
        List<Actor> GetActorsIncludedMovies();
        bool AddMovieToActor (int  movieId,int ActorId);
    }
}
