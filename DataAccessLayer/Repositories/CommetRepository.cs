using DataAccessLayer.Contracts;
using Entities;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository: BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(HttpClient httpClient): base(httpClient, ConnectingTo.comments) { }
    }
}
