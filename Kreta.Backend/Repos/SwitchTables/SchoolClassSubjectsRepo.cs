using Kreta.Backend.Context;
using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.SwitchTable;
using Kreta.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos.SwitchTables
{
    public class SchoolClassSubjectsRepo<TDbContext> : BaseRepo<TDbContext, SchoolClassSubjects>, ISchoolClassSubjectsRepo
        where TDbContext : KretaContext
    {
        public SchoolClassSubjectsRepo(TDbContext? dbContext) : base(dbContext)
        {
        }

        public IQueryable<SchoolClassSubjects> SelectAllIncluded()
        {
            return SelectAll().Include(schoolClassSubjects => schoolClassSubjects.Subject)
                            .Include(SchoolClassSubjects => SchoolClassSubjects.SchoolClass);
        }


        public async Task<Response> MoveToNotStudyingSchoolClassSubjectAsync(SchoolClassSubjects schoolClassSubjectToChange)
        {
            SchoolClassSubjects? schoolClassSubjectToMove =
                SelectAll()
                .FindByCondition(schoolClassSubjects =>
                        schoolClassSubjects.SchoolClassId == schoolClassSubjectToChange.SchoolClassId &&
                        schoolClassSubjects.SubjectId == schoolClassSubjectToChange.SubjectId)
                .FirstOrDefault();
            if (schoolClassSubjectToMove is not null)
            {
                return await DeleteAsync(schoolClassSubjectToMove.Id);
            }
            return new Response("A törlés nem lehetséges!");
        }

        public async Task<Response> MoveToStudyingSchoolClassSubjectAsync(SchoolClassSubjects schoolClassSubjectToChange)
        {
            SchoolClassSubjects newSchoolClassSubjects = new SchoolClassSubjects
            {
                SubjectId = schoolClassSubjectToChange.SubjectId,
                SchoolClassId = schoolClassSubjectToChange.SchoolClassId,
            };
            return await CreateAsync(newSchoolClassSubjects);
        }
    }
}
