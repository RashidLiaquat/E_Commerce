using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IGenaricRepository
    {
        User? GetCurrentUser();
    }
}
