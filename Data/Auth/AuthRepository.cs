using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Data {
    public class AuthRepository : IAuthRepository {
        private readonly DataContextDapper _context;
        public AuthRepository(DataContextDapper context) {
            _context = context;
        }

        public string Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public string RefreshToken()
        {
            throw new NotImplementedException();
        }

        public User Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}