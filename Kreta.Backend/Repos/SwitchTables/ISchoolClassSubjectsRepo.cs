using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.SwitchTable;
using Kreta.Shared.Responses;

namespace Kreta.Backend.Repos.SwitchTables
{
    public interface ISchoolClassSubjectsRepo : IBaseRepo<SchoolClassSubjects>
    {
        public IQueryable<SchoolClassSubjects> SelectAllIncluded();
        public Task<ControllerResponse> MoveToNotStudyingSchoolClassSubjectAsync(SchoolClassSubjects schoolClassSubjectToChange);
        public Task<ControllerResponse> MoveToStudyingSchoolClassSubjectAsync(SchoolClassSubjects schoolClassSubjectToChange);
    }
}
