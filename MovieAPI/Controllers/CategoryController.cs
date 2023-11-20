using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.BLL.Models.DTOs.MovieDTOs;
using MovieAPI.BLL.Services.Abstract;
using MovieAPI.BLL.Services.Concrete;
using MovieAPI.Models.Entities;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        public ActionResult GetCategories()
        {
            return Ok(categoryService.GetAll());
        }
        [HttpPost]
        public ActionResult CreateCategory(string categoryName)
        {
            Category category = new()
            {
                CategoryName= categoryName
            };
            return Ok(categoryService.Add(category));
        }
        [HttpPut]
        public ActionResult UpdateCategory(string categoryName) 
        {
            Category category = new()
            {
                CategoryName = categoryName
            };
            return Ok(categoryService.Update(category));
        }
        [HttpDelete]
        public ActionResult DeleteCategory(int id)
        {
            return Ok(categoryService.Delete(id));
        }
        [HttpGet("Id")]
        public ActionResult GetCategoryById(int id)
        {
            return Ok(categoryService.GetById(id));
        }
    }
}
