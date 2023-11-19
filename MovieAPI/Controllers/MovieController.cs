using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.BLL.Services.Abstract;
using MovieAPI.Models.Entities;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }
        [HttpGet]
        public ActionResult GetMovies()
        {
            return Ok(movieService.GetAll());
        }
    }
}
