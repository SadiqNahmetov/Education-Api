using DomainLayer.Common;
using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task SoftDelete(T entity);
        Task DeleteList(List<T> entities);
        Task<List<T>> FindAllByExpression(Expression<Func<T, bool>> expression);

        Task<bool> IsExsist(Expression<Func<T, bool>> expression);

      




    }
}
