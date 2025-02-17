using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryRepository _subCategoryRepository;

        public SubCategoryController(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        [HttpGet("GetAllSubCategory")]
        public async Task<IActionResult> GetAllSubCategory()
        {
            var subCategories = await _subCategoryRepository.GetAllSubCategories();
            if (subCategories == null)
            {
                throw new KeyNotFoundException("SubCategory List Empty");
            }

            return Ok(subCategories);
        }

        [HttpGet("GetSubCategoryById")]
        public async Task<IActionResult> GetSubCategoryById(int id)
        {
            var subCategory = await _subCategoryRepository.GetsubCategoryById(id);
            if (subCategory == null)
            {
                throw new KeyNotFoundException($"SubCategory with id: {id} not found");
            }
            return Ok(subCategory);
        }

        [HttpPost("AddSubCategory")]
        public async Task<IActionResult> AddSubCategory([FromBody] SubCategorydto subCategorydto)
        {
            if (subCategorydto == null)
            {
                throw new ArgumentNullException(nameof(subCategorydto));
            }
            await _subCategoryRepository.AddSubCategory(subCategorydto);
            return Ok("SubCategory Added Successfully");
        }

        [HttpPut("UpdateSubCategory")]
        public async Task<IActionResult> UpdateSubCategory([FromBody] SubCategorydto subCategorydto, int Id)
        {
            if (subCategorydto == null)
            {
                throw new ArgumentNullException(nameof(subCategorydto));
            }
            await _subCategoryRepository.UpdateSubCategory(subCategorydto, Id);
            return Ok("SubCategory Updated Successfully");
        }

        [HttpDelete("DeleteSubCategory")]
        public async Task<IActionResult> DeleteSubCategory(int Id)
        {
            await _subCategoryRepository.DeleteSubCategory(Id);
            return Ok("SubCategory Deleted Successfully");
        }
    }
}
