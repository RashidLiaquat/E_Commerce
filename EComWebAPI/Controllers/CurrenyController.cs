using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    public class CurrenyController : Controller
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CurrenyController(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        [Authorize]
        [HttpGet("GetAllCurrencies")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            var result = await _currencyRepository.GetAllCurrencies();
            if (result == null)
            {
                return NotFound("Currency List is Empty");
            }

            return Ok(result);
        }

        [Authorize]
        [HttpGet("GetCurrencyById/{Id:int}")]
        public async Task<IActionResult> GetCurrencyById(int Id)
        {
            var result = await _currencyRepository.GetCurrencyById(Id);
            if (result == null)
            {
                return NotFound("Currency is empty");
            }
            return Ok(result);
        }

        [Authorize]
        [HttpPost("AddCurrency")]
        public async Task<IActionResult> AddCurrency([FromBody] Currencydto currencydto)
        {
            await _currencyRepository.AddCurrency(currencydto);
            return Ok("Currency Added Sucessfully!");
        }

        [Authorize]
        [HttpDelete("DeleteCurrency/{Id:int}")]
        public async Task<IActionResult> DeleteCurrency(int Id)
        {
            await _currencyRepository.DeleteCurrency(Id);
            return Ok("Currency Sucessfully deleted");
        }

        [Authorize]
        [HttpPut("UpdateCurrency/{Id:int}")]
        public async Task<IActionResult> UpdateCurrency(int Id, Currencydto currencydto)
        {
            await _currencyRepository.UpdateCurrency(Id, currencydto);
            return Ok("Currency Updated Sucessfully");
        }

    }
}
