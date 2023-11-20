using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.BLL.Models.DTOs.MovieDTOs
{
    public class CreateMovieDTO
    {
        public string MovieName { get; set; }
        public double IMDB { get; set; }
        public int CategoryId { get; set; }
    }
}
