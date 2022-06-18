using server.Models;

namespace server.Data
{
    public interface IUserData
    {
        List<User> GetUsers();
        User GetUser(int id);
        User AddUser(Post post);
        User UpdateUser(User post);
        void DeleteUser(int id);
    }
}
