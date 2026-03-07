namespace CIBERINFRAESTRUCTURA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Intercambiamos la implementación (SOLID - Liskov Substitution)
            // De momento usamos el servicio mockeado de MySQL
            IAuthenticationService authService = new MySqlAuthenticationService();

            Application.Run(new Form1(authService));
        }
    }
}
