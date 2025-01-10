using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Backend.Repos.SwitchTables
{
    public interface ISchoolClassStudentsRepo : IBaseRepo<SchoolClassStudents>
    {
        public IQueryable<SchoolClassStudents> SelectAllIncluded();
    }
}
