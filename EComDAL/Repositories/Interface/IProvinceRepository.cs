using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface IProvinceRepository
    {
        Task<IEnumerable<Province>> GetAllProvince();
        Task<Province> GetProvince(int Id);
        Task AddProvince(Provincedto provincedto);
        Task DeleteProvince(int Id);
        Task UpdateProvince(Provincedto province, int Id);

    }
}
