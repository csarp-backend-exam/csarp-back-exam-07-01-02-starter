using Kreta.Backend.Context;
using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.SwitchTable;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos.SwitchTables
{
    public class SchoolClassStudentsRepo<TDbContext> : BaseRepo<TDbContext, SchoolClassStudents>, ISchoolClassStudentsRepo
        where TDbContext : KretaContext
    {
        public SchoolClassStudentsRepo(TDbContext? dbContext) : base(dbContext)
        {
        }

        public IQueryable<SchoolClassStudents> SelectAllIncluded()
        {
            return SelectAll().Include(schoolClassSubjects => schoolClassSubjects.SchoolClass)
                            .Include(SchoolClassSubjects => SchoolClassSubjects.Student);
        }
    }
}
