using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGenaricRepository _genaricRepository;

        public ProvinceRepository(DataContext context, IMapper mapper, IGenaricRepository genaricRepository)
        {
            _context = context;
            _mapper = mapper;
            _genaricRepository = genaricRepository;
        }
        public async Task AddProvince(Provincedto provincedto)
        {
            var countryexists = await _context.Set<Country>().AnyAsync(c => c.Id == provincedto.CountryId);

            if (!countryexists)
            {
                throw new ArgumentException("Invalid countryid. The country does not exists");
            }


            var mapp = _mapper.Map<Province>(provincedto);
            provincedto.Created_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            provincedto.Created_Date = DateTime.Now;
            await _context.Set<Province>().AddAsync(mapp);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteProvince(int Id)
        {
            var result = await _context.Set<Province>().FindAsync(Id);
            if (result == null)
            {
                throw new KeyNotFoundException();
            }

            _context.Set<Province>().Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Province>> GetAllProvince()
        {
            var result = await _context.Set<Province>()
                .Include(p => p.Country)
                .ToListAsync();
            if (!result.Any())
            {
                throw new KeyNotFoundException("Province not found");
            }

            return result;
        }

        public async Task<Province> GetProvince(int Id)
        {
            var result = await _context.Set<Province>()
                    .Include(p => p.Country)

                    .FirstOrDefaultAsync(p => p.Id == Id);
            if (result == null)
            {
                throw new KeyNotFoundException();
            }

            return result;
        }

        public async Task UpdateProvince(Provincedto provincedto, int Id)
        {
            var result = await _context.Set<Province>().FindAsync(Id);
            if (result == null)
            {
                throw new KeyNotFoundException();
            }
            _mapper.Map(result, provincedto);
            if (provincedto.CountryId != 0)
            {
                var country = await _context.Set<Country>().FindAsync(provincedto.CountryId != 0);

                if (country == null)
                {
                    throw new KeyNotFoundException("Country not Found");
                }

                provincedto.Updated_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
                provincedto.Updated_Date = DateTime.Now;
                result.Country = country;

            }

            await _context.SaveChangesAsync();
        }
    }
}
