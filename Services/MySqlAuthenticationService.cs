using System.Text.RegularExpressions;

namespace CIBERINFRAESTRUCTURA.Services
{
    public class MySqlAuthenticationService : IAuthenticationService
    {
        // Placeholder para la cadena de conexión futura
        private readonly string _connectionString = "Server=localhost;Database=ciber_db;Uid=root;Pwd=password;";

        public bool Authenticate(string username, string password)
        {
            // MOCK: Simulación de consulta a MySQL
            // En el futuro aquí usarías: MySqlConnection, MySqlCommand, etc.
            Console.WriteLine($"Conectando a MySQL con: {_connectionString}");
            
            // Simulación de usuario en BD
            return username == "admin_db" && password == "SecurePass123!";
        }

        public bool ValidatePasswordComplexity(string password)
        {
            // Reutilizamos la lógica de complejidad (Regex) solicitada
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
