using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;      
        }

        [HttpGet ("Get_Countries")]
        public async Task<IActionResult> GetAllCountries()
        {
            var result = await _countryRepository.GetAllCountry();
            if (result == null)
            {
                return NotFound("Country List is empty");
            }
            return Ok(result);
        }
        [HttpGet("GetCountryById/{Id:int}")]
        public async Task<IActionResult> GetCountryById(int Id)
        {
            var result = await _countryRepository.GetCountryById(Id);
            if (result == null)
            {
                return NotFound("Country is Not Found");
            }
            return Ok(result);
        }
        [HttpPost ("Add_Country")]
        public async Task<IActionResult> AddCountry([FromBody] Countrydto countrydto)
        {
            await _countryRepository.AddCountry(countrydto);
            return Ok("Country Sucessfully Added");
        }
        [HttpPost("DeleteCountry/{Id:int}")]
        public async Task<IActionResult> DeleteCountry(int Id)
        {
            await _countryRepository.DeleteCountry(Id);
            return Ok("Country Deleted Sucessfully");
        }
        [HttpPost("UpdateCountry/{Id:int}")]
        public async Task<IActionResult> UpdateCountry(int Id,Countrydto countrydto)
        {
            await _countryRepository.UpdateCountry(countrydto, Id);
            return Ok("Country Updated Sucessfully");
        }

    }
}
