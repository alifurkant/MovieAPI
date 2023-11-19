using MovieAPI.Entities.Models.Entities;

namespace MovieAPI.Models.Entities
{
    public class Movie : BaseEntity
    {
        public Movie()
        {
            Actors = new List<Actor>();
        }
        public string MovieName { get; set; }
        public double IMDB { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set;}
        public List<Actor> Actors { get; set; }

    }
}
