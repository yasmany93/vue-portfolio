using DataAccessLayer.Contracts;
using Entities;

namespace DataAccessLayer.Repositories
{
    public class PostRepository: BaseRepository<Post>, IPostRepository
    {
        public PostRepository(HttpClient httpClient): base(httpClient, ConnectingTo.posts) { }
    }
}
