using Entities;

namespace DataAccessLayer.Contracts
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> FindAllAsync();
        //Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        Task<Comment> FindByIdAsync(int id);
        void CreateAsync(Comment entity);
        void UpdateAsync(Comment entity);
        void DeleteAsync(Comment entity);
    }
}
