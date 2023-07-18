using Entities;

namespace DataAccessLayer.Contracts
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> FindAllAsync();
        //Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        Task<Post> FindByIdAsync(int id);
        void CreateAsync(Post entity);
        void UpdateAsync(Post entity);
        void DeleteAsync(Post entity);
    }
}
