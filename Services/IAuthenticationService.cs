namespace CIBERINFRAESTRUCTURA.Services
{
    public interface IAuthenticationService
    {
        bool Authenticate(string username, string password);
        bool ValidatePasswordComplexity(string password);
    }
}
