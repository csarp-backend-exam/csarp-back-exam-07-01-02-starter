using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SchoolClassRepo<TDbContext> : BaseRepo<TDbContext, SchoolClass>, ISchoolClassRepo
        where TDbContext : DbContext
    {
        public SchoolClassRepo(TDbContext? dbContext) : base(dbContext)
        {
        }

        public IQueryable<SchoolClass> SelectAllIncluded()
        {
            return SelectAll().Include(schoolClass => schoolClass.TypeOfEducation);
        }

        public IQueryable<SchoolClass> GetSchoolClassBy(Guid typeOfEducationID)
        {
            return SelectAll().Where(schoolClass => schoolClass.TypeOfEducationId == typeOfEducationID);
        }

        public IQueryable<SchoolClass> SelectWithoutTypeOfEducation()
        {
            return SelectAll().Where(schoolClass =>
              schoolClass.TypeOfEducationId == null ||
              schoolClass.TypeOfEducationId == Guid.Empty);
        }

        public IQueryable<SchoolClass> SelectSchoolClassesWithSubjects()
        {
            return SelectAll()
                    .Include(schoolClasses => schoolClasses.SchoolClassSubjects)
                    .ThenInclude(schoolClassSubjects => schoolClassSubjects.Subject);
        }
    }
}
