using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public IQueryable<Student> SelectAllIncluded();

        public IQueryable<Student> SelectStudentsByEducationId(Guid educationID);

        public IQueryable<Student> SelectStudentsWithoutEducationLevel();
    }
}
