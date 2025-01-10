using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class TeacherRepo<TDbContext> : BaseRepo<TDbContext, Teacher>, ITeacherRepo
        where TDbContext : DbContext
    {
        public TeacherRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
