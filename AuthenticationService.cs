using System.Text.RegularExpressions;

namespace CIBERINFRAESTRUCTURA
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool Authenticate(string username, string password)
        {
            return username == "admin" && password == "Admin123!";
        }

        public bool ValidatePasswordComplexity(string password)
        {
            // Regex: 
            // (?=.*[a-z]) : Al menos una minúscula
            // (?=.*[A-Z]) : Al menos una mayúscula
            // (?=.*\d)    : Al menos un número
            // (?=.*[^\da-zA-Z]) : Al menos un símbolo (no alfanumérico)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
