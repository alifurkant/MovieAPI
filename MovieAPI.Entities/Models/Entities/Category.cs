using MovieAPI.Entities.Models.Entities;

namespace MovieAPI.Models.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Movies = new List<Movie>();
        }
        public string CategoryName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
