using System.Collections.Generic;

using CIBERINFRAESTRUCTURA.Models;

namespace CIBERINFRAESTRUCTURA.Services
{
    public interface IPersonalService
    {
        List<Personal> GetAll(string connectionString);
    }
}
