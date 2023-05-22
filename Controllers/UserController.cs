using QRCodeWebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using QRCodeWebAPI.Data;
using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Controllers {

    // [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _config;

        public UserController(IConfiguration config, IUserRepository userRepository) {
            _config = config;
            _userRepository = userRepository;
        }

        [HttpGet("GetUsers")]
        public IEnumerable<User> GetUsers() {
            return _userRepository.GetUsers();
        }        

        [HttpGet("GetUser/{id}")]
        public User GetUser(int id) {
            return _userRepository.GetUser(id);
        }

        [HttpGet("GetUserByEmail/{email}")]
        public User GetUserByEmail(string email) {
            return _userRepository.GetUserByEmail(email);
        }

        [HttpPut("UpsertUser")]
        public bool UpdateUser(User user) {
            return _userRepository.UpsertUser(user);
        }

        [HttpDelete("DeleteUser/{id}")]
        public bool DeleteUser(int id) {
            return _userRepository.DeleteUser(id);
        }

    }
}
