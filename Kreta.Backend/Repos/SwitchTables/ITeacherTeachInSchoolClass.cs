using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Backend.Repos.SwitchTables
{
    public interface ITeacherTeachInSchoolClass : IBaseRepo<TeachersTeachInSchoolClass>
    {
        public IQueryable<TeachersTeachInSchoolClass> SelectAllIncluded();
    }
}
