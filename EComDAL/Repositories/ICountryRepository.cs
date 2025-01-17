using EComDAL.Context;
using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories
{
    internal interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int id);
        void AddCountory(Country country);
        void UpdateCountory(Country country);
        void DeleteCountory(int id);
    }

    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;

        public CountryRepository(DataContext context)
        {
            _context = context;
        }

        public void AddCountory(Country country)
        {
            throw new NotImplementedException();
        }

        public void DeleteCountory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Country GetCountryById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCountory(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
