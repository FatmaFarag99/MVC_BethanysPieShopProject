namespace BethanysPieShopProject.Models.Repositories
{
    using BethanysPieShopProject.Models.Context;
    using System.Collections.Generic;

    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Category> AllCategories => _applicationDbContext.Categories;
    }
}
