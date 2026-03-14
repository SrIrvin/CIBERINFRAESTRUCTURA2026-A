using System.Collections.Generic;

namespace CIBERINFRAESTRUCTURA
{
    public interface IPersonalService
    {
        List<Personal> GetAll(string connectionString);
    }
}
