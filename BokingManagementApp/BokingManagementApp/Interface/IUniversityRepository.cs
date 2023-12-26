using BokingManagementApp.Base;
using BokingManagementApp.Models;

namespace BokingManagementApp.Interface
{
    public interface IUniversityRepository : IBaseRepository<University>
    {
        IEnumerable<University> GetByName(string name);
        University? GetByCodeName(string code, string name);
        bool IsNameExist(string name);
        University? GetName(string name);

        String GeneratedCode();
    }
}
