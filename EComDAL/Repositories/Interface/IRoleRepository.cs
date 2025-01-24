using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Roledto>> GetAllRole();
        Task<Role> GetRoleById(int id);
        Task AddRoleAsync(Roledto roledto);
        Task Updated(Roledto roledto, int Id);
        Task DeleteRoleAsync(int id);

    }
}
