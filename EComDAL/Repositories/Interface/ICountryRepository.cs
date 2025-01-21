using EComDAL.DTOs;
using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Repositories.Interface
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountry();
        Task<Country> GetCountryById(int Id);
        Task AddCountry(Countrydto countrydto);
        Task DeleteCountry(int Id);
        Task UpdateCountry(Countrydto countrydto, int Id);
    }
}
