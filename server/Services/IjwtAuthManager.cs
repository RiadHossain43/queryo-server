namespace server.Services
{
    public interface IjwtAuthManager
    {
        string Authenticate(string email, string name,int id);
    }
}
