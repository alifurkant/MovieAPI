﻿using MovieAPI.BLL.Services.Abstract;
using MovieAPI.DAL.Repositories.Abstract;
using MovieAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.BLL.Services.Concrete
{
    public class CategoryService : BaseService<Category>,ICategoryService
    {
        private readonly IBaseRepository<Category> baseRepository;
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(IBaseRepository<Category> baseRepository, ICategoryRepository categoryRepository):base(baseRepository)
        {
            this.baseRepository = baseRepository;
            this.categoryRepository = categoryRepository;
        }

        public List<Category> GetCategoriesIncludedMovies()
        {
            return categoryRepository.GetCategoriesIncludedMovies();
        }
    }
}
