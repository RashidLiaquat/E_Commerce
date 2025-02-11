using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int Id);
        Task AddUser(Userdto userdto);
        Task DeleteUser(int Id);
        Task SoftDelete(int id);
        Task UpdateUser(UserUpdatedto userdto, int Id);
    }
}
