using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.BLL.Models.DTOs;
using MovieAPI.BLL.Models.DTOs.MovieDTOs;
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
        [HttpGet("GetMovies")]
        public ActionResult GetMovies()
        {
            return Ok(movieService.GetMoviesIncludedActorsCategories());
        }
        [HttpPost("CreateMovie")]
        public ActionResult CreateMovie(CreateMovieDTO movieDTO)
        {
            Movie movie = new()
            {
                MovieName= movieDTO.MovieName,
                CategoryId= movieDTO.CategoryId,
                IMDB = movieDTO.IMDB
            };
            return Ok(movieService.Add(movie));
        }
        [HttpPut("UpdateMovie")]
        public ActionResult UpdateMovie(UpdateMovieDTO movieDTO)
        {
            Movie movie = new()
            {
                Id= movieDTO.Id,
                MovieName = movieDTO.MovieName,
                CategoryId = movieDTO.CategoryId,
                IMDB = movieDTO.IMDB
            };
            return Ok(movieService.Update(movie));
        }
        [HttpDelete("DeleteMovie")]
        public ActionResult DeleteMovie(int id)
        {
            return Ok(movieService.Delete(id));
        }
        [HttpGet("GetById")]
        public ActionResult GetMovieById(int id)
        {
            return Ok(movieService.GetById(id));
        }
        [HttpPost("AddActorToMovie")]
        public ActionResult AddActorToMovie(AddActorToMovieDTO addActorToMovieDTO)
        {
            return Ok(movieService.AddActorToMovie(addActorToMovieDTO.ActorId, addActorToMovieDTO.MovieId));
        }
    }
}
