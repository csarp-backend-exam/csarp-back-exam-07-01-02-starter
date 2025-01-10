﻿using Kreta.Shared.Responses;
using System.Linq.Expressions;

namespace Kreta.Backend.Repos.Base
{
    public interface IBaseRepo<T>
    {
        IQueryable<T> GetEmpty();
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<ControllerResponse> CreateAsync(T entity);
        Task<ControllerResponse> UpdateAsync(T entity);
        Task<ControllerResponse> DeleteAsync(Guid id);
    }
}