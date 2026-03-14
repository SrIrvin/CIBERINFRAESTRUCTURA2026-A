using CIBERINFRAESTRUCTURA.UI;
using CIBERINFRAESTRUCTURA.Services;

namespace CIBERINFRAESTRUCTURA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new DatabaseConfigForm());
        }
    }
}
