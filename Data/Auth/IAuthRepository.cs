using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Data {
    public interface IAuthRepository {
        User Register(User user, string password);
        String Login(String email, String password);
        String RefreshToken();
        Boolean UserExists(String email);
    }
}