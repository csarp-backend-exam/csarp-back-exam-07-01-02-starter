using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models;

namespace Kreta.Backend.Repos
{
    public interface ITypeOfEducationRepo : IBaseRepo<TypeOfEducation>
    {
        public IQueryable<TypeOfEducation> SelectAllIncluded();
    }
}
