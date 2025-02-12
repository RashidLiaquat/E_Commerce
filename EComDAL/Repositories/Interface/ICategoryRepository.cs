using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int Id);
        Task AddCategory(Categorydto categorydto);
        Task UpdateCategory(Categorydto categorydto, int Id);
        Task DeleteCategory(int Id);

    }
}
