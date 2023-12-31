using Microsoft.EntityFrameworkCore;
using MovieAPI.BLL.Services.Abstract;
using MovieAPI.BLL.Services.Concrete;
using MovieAPI.DAL.Repositories.Abstract;
using MovieAPI.DAL.Repositories.Concrete;
using MovieAPI.Entities.Context;

namespace MovieAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Server=DESKTOP-9OHK71U; Database=MovieApiDB; Trusted_Connection=True;"));

            builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            builder.Services.AddTransient(typeof(IMovieRepository), typeof(MovieRepository));
            builder.Services.AddTransient(typeof(IActorRepository), typeof(ActorRepository));
            builder.Services.AddTransient(typeof(ICategoryRepository), typeof(CategoryRepository));

            builder.Services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            builder.Services.AddTransient(typeof(IMovieService), typeof(MovieService));
            builder.Services.AddTransient(typeof(IActorService), typeof(ActorService));
            builder.Services.AddTransient(typeof(ICategoryService), typeof(CategoryService));

            builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler =
                    System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}