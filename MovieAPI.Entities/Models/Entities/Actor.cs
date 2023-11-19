using MovieAPI.Entities.Models.Entities;

namespace MovieAPI.Models.Entities
{
    public class Actor : BaseEntity
    {
        public Actor()
        {
            Movies = new List<Movie>();
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year-BirthDate.Year;
            }
        }
        public List<Movie> Movies { get; set; }
        

    }
}
