using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [Authorize]
        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
        {
            var categories = await _categoryRepository.GetAllCategories();

            if (categories == null)
            {
                throw new KeyNotFoundException($"Category List Empty");
            }

            return Ok(categories);
        }

        [Authorize]
        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _categoryRepository.GetCategoryById(id);
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with id: {id} not found");
            }
            return Ok(category);
        }
        [Authorize]
        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory([FromBody] Categorydto categorydto)
        {
            if (categorydto == null)
            {
                throw new ArgumentNullException(nameof(categorydto));
            }
            await _categoryRepository.AddCategory(categorydto);
            return Ok("Category Added Successfully");
        }

        [Authorize]
        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody] Categorydto categorydto, int Id)
        {

            if (categorydto == null)
            {
                throw new ArgumentNullException(nameof(categorydto));
            }
            await _categoryRepository.UpdateCategory(categorydto, Id);
            return Ok("Category Updated Successfully");
        }

        [Authorize]
        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory(int Id)
        {
            await _categoryRepository.DeleteCategory(Id);
            return Ok("Category Deleted Successfully");
        }

    }
}
