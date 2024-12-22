using WebAPI_IMS.Data.Entities;
using WebAPI_IMS.Data.Repository_Layer.Repository_Interfaces;
using WebAPI_IMS.Data.Service_Layer.Service_Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI_IMS.Data.Service_Layer
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _categoryRepository.AddCategoryAsync(category);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllCategoriesAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepository.GetCategoryByIdAsync(id);
        }
    }
}
