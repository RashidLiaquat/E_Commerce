using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGenaricRepository _genaricRepository;

        public CurrencyRepository(DataContext dataContext, IMapper mapper, IGenaricRepository genaricRepository)
        {
            _context = dataContext;
            _mapper = mapper;
            _genaricRepository = genaricRepository;

        }

        public async Task AddCurrency(Currencydto currencydto)
        {
            if (_context.Currencies == null)
            {
                throw new KeyNotFoundException($"Currencies is Empty");
            }

            var mapp = _mapper.Map<Currency>(currencydto);
            currencydto.Created_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            currencydto.Created_Date = DateTime.Now;
            await _context.Set<Currency>().AddAsync(mapp);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCurrency(int Id)
        {

            var result = await _context.Set<Currency>().FindAsync(Id);

            if (result != null && result.IsActive == true)
            {
                _context.Set<Currency>().Remove(result);
                await _context.SaveChangesAsync();
            }

            else if (result != null)
            {
                result.IsActive = false;
                await _context.SaveChangesAsync();
            }
            else
            {

                throw new KeyNotFoundException($"Currency Not Found");
            }

        }

        public async Task<IEnumerable<Currency>> GetAllCurrencies()
        {
            var result = await _context.Currencies.Where(c => c.IsActive == true).ToListAsync();

            if (!result.Any())
            {
                throw new KeyNotFoundException("Currency not found");
            }

            return result;

        }

        public async Task<Currency> GetCurrencyById(int Id)
        {
            var result = await _context.Currencies.Where(c => c.IsActive == true && c.Id == Id).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new KeyNotFoundException("Currency not found");
            }

            return result;
        }

        public async Task UpdateCurrency(int Id, Currencydto currencydto)
        {
            var result = await _context.Currencies.Where(c => c.IsActive && c.Id == Id).FirstOrDefaultAsync();
            var currentUser = _genaricRepository.GetCurrentUser();

            if (result == null)
            {
                throw new KeyNotFoundException("Currency not found");
            }

            _mapper.Map(currencydto, result);


            if (currentUser == null)
            {
                throw new InvalidOperationException("Current user not found");
            }
            currencydto.Updated_By = currentUser.UserName ?? throw new InvalidOperationException("Current user is null");
            currencydto.Updated_Date = DateTime.Now;
            await _context.SaveChangesAsync();
        }
    }
}
