﻿using Kreta.Backend.Repos.Base;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class EducationLevelRepo<TDbContext> : BaseRepo<TDbContext, EducationLevel>, IEducationLevelRepo
        where TDbContext : DbContext
    {
        public EducationLevelRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
        public IQueryable<EducationLevel> SelectAllIncluded()
        {
            return FindAll().Include(educationLevel => educationLevel.Students);
        }
    }
}
