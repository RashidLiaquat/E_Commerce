using EComDAL.DTOs;
using EComDAL.Repositories;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        [HttpGet("GetRoleList")]
        public async Task<IActionResult> GetRoleList()
        {
            var result = await _roleRepository.GetAllRole();

            if (result == null || !result.Any())
            {
                return BadRequest("Not Found");
            }

            return Ok(result);
        }

        [HttpGet("GetRoleById/{id:int}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var result = await _roleRepository.GetRoleById(id);

            if (result == null)
            {
                return BadRequest("Not Found");
            }

            return Ok(result);
        }

        [HttpPost("Add_Role")]
        public async Task<IActionResult> AddRole([FromBody] Roledto roledto)
        {
            await _roleRepository.AddRoleAsync(roledto);

            return Ok("Role sucessfully Added!");
        }

        [HttpDelete("Delete_Role/{id:int}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            await _roleRepository.DeleteRoleAsync(id);
            return Ok("Role sucessfully Deleted!");
        }

        [HttpPost("Update_Role/{Id:int}")]
        public async Task<IActionResult> Update(Roledto roledto,int Id) 
        {
            await _roleRepository.Updated(roledto,Id);

            return Ok("Role sucessfully Updated!");
        }
    }
}
