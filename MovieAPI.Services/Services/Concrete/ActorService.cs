using MovieAPI.BLL.Services.Abstract;
using MovieAPI.DAL.Repositories.Abstract;
using MovieAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.BLL.Services.Concrete
{
    public class ActorService : BaseService<Actor> , IActorService
    {
        private readonly IBaseRepository<Actor> baseRepository;
        private readonly IActorRepository actorRepository;

        public ActorService(IBaseRepository<Actor> baseRepository,IActorRepository actorRepository): base(baseRepository)
        {
            this.baseRepository = baseRepository;
            this.actorRepository = actorRepository;
        }

        public bool AddMovieToActor(int movieId, int ActorId)
        {
            return actorRepository.AddMovieToActor(movieId, ActorId);
        }

        public List<Actor> GetActorsIncludedMovies()
        {
            return actorRepository.GetActorsIncludedMovies();
        }
    }
}
