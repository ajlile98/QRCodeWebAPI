using Dapper;
using QRCodeWebAPI.Data;
using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Data {
    public class UserRepository : IUserRepository
    {
        private readonly DataContextDapper _dapper;
        private readonly IConfiguration _config;
        public UserRepository(IConfiguration config)
        {
            _config = config;
            _dapper = new DataContextDapper(_config);
        }

        public bool DeleteUser(int id)
        {
            String sql = "DELETE FROM QRCodeApiSchema.Users WHERE UserId = @UserId";
            DynamicParameters sqlParameters = new DynamicParameters(); 
            sqlParameters.Add("@UserId", id);
            return _dapper.ExecuteSqlWithParameters(sql, sqlParameters);
        }

        public User GetUser(int id)
        {
            String sql = "SELECT User FROM Users WHERE UserId = @UserId";
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers(int userId = 0)
        {               
            List<User> users = new List<User>();
            users.Add(new User() { UserId = 1, FirstName = "John", LastName = "Doe", Email = "John.Doe@gmail.com", Active = true});
            users.Add(new User() { UserId = 2, FirstName = "Jane", LastName = "Doe", Email = "Jane.Doe@gmail.com", Active = true});
            return users;
        }

        public bool UpsertUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}