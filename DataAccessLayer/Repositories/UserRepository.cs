using DataAccessLayer.Contracts;
using Entities;

namespace DataAccessLayer.Repositories
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(HttpClient httpClient): base(httpClient, ConnectingTo.users) { }
    }
}
