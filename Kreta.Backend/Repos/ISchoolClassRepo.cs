using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models;

namespace Kreta.Backend.Repos
{
    public interface ISchoolClassRepo : IBaseRepo<SchoolClass>
    {
        public IQueryable<SchoolClass> SelectAllIncluded();
        public IQueryable<SchoolClass> GetSchoolClassBy(Guid typeOfEducationID);
        public IQueryable<SchoolClass> SelectWithoutTypeOfEducation();
        public IQueryable<SchoolClass> SelectSchoolClassesWithSubjects();
    }
}
