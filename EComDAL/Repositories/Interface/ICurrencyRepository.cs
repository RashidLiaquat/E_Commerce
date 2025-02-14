using EComDAL.DTOs;
using EComDAL.Model;

namespace EComDAL.Repositories.Interface
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> GetAllCurrencies();
        Task<Currency> GetCurrencyById(int Id);
        Task AddCurrency(Currencydto currencydto);
        Task UpdateCurrency(int Id, Currencydto currencydto);
        Task DeleteCurrency(int Id);
    }
}
