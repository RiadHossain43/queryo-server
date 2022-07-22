namespace server.Services
{
    public interface IjwtAuthManager
    {
        string Authenticate(string email, string password);
    }
}
