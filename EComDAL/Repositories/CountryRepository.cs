﻿using AutoMapper;
using EComDAL.Context;
using EComDAL.DTOs;
using EComDAL.Model;
using EComDAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComDAL.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IGenaricRepository _genaricRepository;
        public CountryRepository(DataContext context, IMapper mapper, IGenaricRepository genaricRepository)
        {
            _context = context;
            _mapper = mapper;
            _genaricRepository = genaricRepository;
        }

        public async Task<IEnumerable<Country>> GetAllCountry()
        {
            var country = await _context.Set<Country>()
                .ToListAsync();
            if (!country.Any())
            {
                throw new KeyNotFoundException($"Roles list is empty");
            }
            return country;

        }
        public async Task<Country> GetCountryById(int Id)
        {
            var result = await _context.Set<Country>().FindAsync(Id);
            if (result == null)
            {
                throw new KeyNotFoundException("Country Not Found");
            }
            return result;
        }
        public async Task AddCountry(Countrydto countrydto)
        {
            var country = _mapper.Map<Country>(countrydto);
            if (country == null)
            {
                throw new KeyNotFoundException("Country Not Found");
            }
            country.CreatedBy = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            country.CreatedDate = DateTime.Now;
            await _context.Set<Country>().AddAsync(country);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCountry(int Id)
        {
            var result = await _context.Set<Country>().FindAsync(Id);
            if (result == null)
            {
                throw new KeyNotFoundException("Country Not Found");
            }
            _context.Set<Country>().Remove(result);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateCountry(Countrydto countrydto, int Id)
        {
            var result = await _context.Set<Country>().FindAsync(Id);
            if (result == null)
            {
                throw new KeyNotFoundException("Country Not Found");
            }
            _mapper.Map(countrydto, result);
            countrydto.Updated_By = _genaricRepository.GetCurrentUser()?.UserName ?? throw new InvalidOperationException("Current user is null");
            countrydto.Updated_Date = DateTime.Now;
            _context.Set<Country>().Update(result);
            await _context.SaveChangesAsync();
        }

    }
}
