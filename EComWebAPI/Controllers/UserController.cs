using EComDAL.DTOs;
using EComDAL.Repositories;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        public UserController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        [Authorize]
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] Userdto userdto)
        {
            await _usersRepository.AddUser(userdto);
            return Ok("User Registered Successfully");
        }


        [Authorize]
        [HttpPost("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers() 
        {
            var result = await _usersRepository.GetAllUsers();
            if (result == null)
            {
                return NotFound("User List is Empty");
            }

            return Ok(result);
        }

        [HttpPost("UpdateUsers/{Id:int}")]
        public async Task<IActionResult> UpdateUsers(int Id, UserUpdatedto userdto)
        {
            await _usersRepository.UpdateUser(userdto, Id);
            return Ok("Users Updated Sucessfully");
        }

        [Authorize]
        [HttpGet("GetUserById/{Id:int}")]
        public async Task<IActionResult> GetUserById(int Id)
        {
            var result = await _usersRepository.GetUserById(Id);
            if (result == null)
            {
                return NotFound("User is Not Found");
            }
            return Ok(result);
        }



        [Authorize]
        [HttpDelete("Permanantle_Delete/{Id:int}")]
        public async Task<IActionResult> PermanantleDelete(int Id)
        {
            await _usersRepository.DeleteUser(Id);
            return Ok("User Deleted Successfully");
        }

        [Authorize]
        [HttpDelete("Soft_DeleteUser/{Id:int}")]
        public async Task<IActionResult> SoftDelete(int Id)
        {
            await _usersRepository.SoftDelete(Id);
            return Ok("User Deleted Successfully");
        }
    }
}
