using server.Models;

namespace server.Data
{
    public interface IUserData
    {
        List<User> GetUsers();
        User GetUserByEmail(string email);
        User GetUserById(int id);
        User AddUser(User post);
        User UpdateUser(User post);
        void DeleteUser(int id);
    }
}
