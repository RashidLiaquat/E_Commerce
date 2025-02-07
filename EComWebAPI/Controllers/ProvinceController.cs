using AutoMapper;
using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ProvinceController : Controller
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMapper _mapper;

        public ProvinceController(IProvinceRepository provinceRepository, IMapper mapper)
        {
            _provinceRepository = provinceRepository;
            _mapper = mapper;
        }
        [Authorize]
        [HttpGet("GetAllProvince")]
        public async Task<IActionResult> GetAllProvince()
        {
            var result = await _provinceRepository.GetAllProvince();
            if (result == null)
            {
                return NotFound("Province List is empty");
            }



            return Ok(result);
        }
        [Authorize]
        [HttpGet("GetProvinceById/{Id:int}")]
        public async Task<IActionResult> GetProvinceById(int Id)
        {
            var result = await _provinceRepository.GetProvince(Id);
            if (result == null)
            {
                return NotFound("Province is empty");
            }
            return Ok(result);
        }
        [Authorize]
        [HttpPost("AddProvince")]
        public async Task<IActionResult> AddProvince([FromBody] Provincedto province)
        {
            await _provinceRepository.AddProvince(province);
            return Ok("Province Added Sucessfully!");
        }
        [Authorize]
        [HttpDelete("DeleteProvince/{Id:int}")]
        public async Task<IActionResult> DeleteProvince(int Id)
        {
            await _provinceRepository.DeleteProvince(Id);

            return Ok("Province Sucessfully deleted");
        }
        [Authorize]
        [HttpPost("Updateprovince/{Id:int}")]
        public async Task<IActionResult> UpdateProvince(Provincedto provincedto, int Id)
        {
            await _provinceRepository.UpdateProvince(provincedto, Id);
            return Ok("Record updated Sucessfully!");
        }
    }
}
