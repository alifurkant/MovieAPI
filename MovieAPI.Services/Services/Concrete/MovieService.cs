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
    public class MovieService : BaseService<Movie> , IMovieService
    {
        private readonly IBaseRepository<Movie> baseRepository;
        private readonly IMovieRepository movieRepository;

        public MovieService(IBaseRepository<Movie> baseRepository,IMovieRepository movieRepository): base(baseRepository)
        {
            this.baseRepository = baseRepository;
            this.movieRepository = movieRepository;
        }
    }
}
