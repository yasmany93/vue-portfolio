using Entities;

namespace DataAccessLayer.Contracts
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> FindAllAsync();
        //Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        Task<User> FindByIdAsync(int id);
        void CreateAsync(User entity);
        void UpdateAsync(User entity);
        void DeleteAsync(User entity);
    }
}
