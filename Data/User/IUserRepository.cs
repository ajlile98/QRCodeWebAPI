using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Data {
    public interface IUserRepository {
        IEnumerable<User> GetUsers(int userId=0);
        User GetUser(int id);
        User GetUserByEmail(string email);
        bool UpsertUser(User user);
        bool DeleteUser(int id);
    }
}