using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController: ControllerBase
    {
        private readonly IAuthRepository _repo;

        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Resister(UserforRegisterDto userforRegisterDto)
        {
            // validation request
            userforRegisterDto.Username = userforRegisterDto.Username.ToLower();
            if(await _repo.UserExists(userforRegisterDto.Username )) 
               return BadRequest("Username already exists");
            var userToCreate = new User{
                Username = userforRegisterDto.Username 
            };
            var createdUser = await _repo.Register(userToCreate,userforRegisterDto.Password);
            return StatusCode(201);
        }
    }
}