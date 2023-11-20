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
    }
}
