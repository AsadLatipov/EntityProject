using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EntityProject.Data.IRepository;
using EntityProject.Domain.Models;

namespace EntityProject.Service.Interfaces
{
    public interface IGroupInterface
    {
        Task<Group> CreateAsycn(Group entity);
        Task<Group> GetAsync(Expression<Func<Group, bool>> expression);
        Task<IEnumerable<Group>> GetAllAsync(Expression<Func<Group, bool>> expression = null);
        Task<Group> UpdateAsync(Group entity);
        Task<Group> DeleteAsync(Expression<Func<Group, bool>> expression);
    }
}