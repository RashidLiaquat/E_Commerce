using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface ISubCategoryRepository
    {
        Task<IEnumerable<SubCategory>> GetAllSubCategories();
        Task<SubCategory> GetsubCategoryById(int Id);
        Task AddSubCategory(SubCategorydto subCategorydto);
        Task UpdateSubCategory(SubCategorydto subCategorydto, int Id);
        Task DeleteSubCategory(int Id);
    }
}
