namespace CIBERINFRAESTRUCTURA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Composición de dependencias (Clean Code / SOLID)
            IAuthenticationService authService = new AuthenticationService();
            
            // Inyección manual del servicio en el formulario
            Application.Run(new Form1(authService));
        }
    }
}
