using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityProject.Data.Repository;
using EntityProject.Domain.Models;
using EntityProject.Service.Interfaces;


namespace EntityProject.Service.Services
{
    public class GroupService :IGroupInterface
    {
        GenericRepository<Group> _repository = new GenericRepository<Group>();
        public Task<Group> CreateAsycn(Group entity)
        {
            throw new NotImplementedException();
        }

        public Task<Group> DeleteAsync(Expression<Func<Group, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Group>> GetAllAsync(Expression<Func<Group, bool>> expression = null)
        {
            IQueryable<Group> res = await _repository.GetAllAsync(expression);
            return res.Include(p => p.Students).Include(p => p.Teachers);
        }

        public Task<Group> GetAsync(Expression<Func<Group, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Group> UpdateAsync(Group entity)
        {
            throw new NotImplementedException();
        }
    }
}
