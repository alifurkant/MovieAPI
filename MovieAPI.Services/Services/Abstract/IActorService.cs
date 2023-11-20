using MovieAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.BLL.Services.Abstract
{
    public interface IActorService : IBaseService<Actor>
    {
        List<Actor> GetActorsIncludedMovies();
        bool AddMovieToActor(int movieId, int ActorId);
    }
}
