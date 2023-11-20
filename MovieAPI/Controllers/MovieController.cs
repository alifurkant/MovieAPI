using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public ActionResult GetMovies()
        {
            return Ok(movieService.GetAll());
        }
        [HttpPost]
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
        [HttpPut]
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
        [HttpDelete]
        public ActionResult DeleteMovie(int id)
        {
            return Ok(movieService.Delete(id));
        }
        [HttpGet("Id")]
        public ActionResult GetMovieById(int id)
        {
            return Ok(movieService.GetById(id));
        }
    }
}
