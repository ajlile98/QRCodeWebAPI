using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QRCodeWebAPI.Data;
using QRCodeWebAPI.DTO;
using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Controllers {


    [Authorize]
    [ApiController]
    [Route("api/[controller]")] 
    public class AuthController : ControllerBase {

        IAuthRepository _authRepository;
        IConfiguration _config;
        public AuthController(IConfiguration config, IAuthRepository authRepository) {
            _config = config;
            _authRepository = authRepository;
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public IActionResult Register(UserForRegisterDto userForRegisterDto) {

            if (userForRegisterDto.Password != userForRegisterDto.ConfirmPassword) {
                return BadRequest("Passwords do not match");
            }
            // validate request
            userForRegisterDto.Email = userForRegisterDto.Email.ToLower();

            if (_authRepository.UserExists(userForRegisterDto.Email)) {
                return BadRequest("Email already exists");
            }

            var userToCreate = new User {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Active = true
            };

            var createdUser = _authRepository.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login(UserForLoginDto userForLogin){
            var user = _authRepository.Login(userForLogin.Email.ToLower(), userForLogin.Password);
            return StatusCode(200);
        }

        [HttpGet("RefreshToken")]
        public IActionResult RefreshToken(){
            var user = _authRepository.RefreshToken();
            return StatusCode(200);
        }
    }
}