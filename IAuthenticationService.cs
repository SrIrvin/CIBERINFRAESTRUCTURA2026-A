namespace CIBERINFRAESTRUCTURA
{
    public interface IAuthenticationService
    {
        bool Authenticate(string username, string password);
        bool ValidatePasswordComplexity(string password);
    }
}
