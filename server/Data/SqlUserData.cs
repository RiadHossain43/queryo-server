using server.Models;

namespace server.Data
{
    public class SqlUserData : IUserData
    {
        private ApplicationDbContext _applicationDbContext;
        public SqlUserData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public User AddUser(User user)
        {
            _applicationDbContext.Users.Add(user);
            _applicationDbContext.SaveChanges();
            return user;
        }

        public User GetUserByEmail(string email)
        {
            return _applicationDbContext.Users.Where(user=>user.Email.Equals(email)).First();
        }

        public User GetUserById(int id)
        {
            return _applicationDbContext.Users.Find(id);
        }

        public List<User> GetUsers()
        {
            return _applicationDbContext.Users.ToList();
        }

        public User UpdateUser(User user)
        {
            _applicationDbContext.Users.Update(user);
            _applicationDbContext.SaveChanges();
            return user;
        }
        public void DeleteUser(int id)
        {
            var user = _applicationDbContext.Users.Find(id);
            if (user != null)
            {
                _applicationDbContext.Users.Remove(user);
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
