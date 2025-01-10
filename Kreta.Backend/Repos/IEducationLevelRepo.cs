using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Backend.Repos
{
    public interface IEducationLevelRepo : IBaseRepo<EducationLevel>
    {
        public IQueryable<EducationLevel> SelectAllIncluded();
    }
}
