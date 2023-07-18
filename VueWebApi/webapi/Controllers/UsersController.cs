using Microsoft.AspNetCore.Mvc;
using Entities;
using DataAccessLayer.Contracts;

namespace webapi.Controllers
{
    public class UsersController : Controller
    {
        IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Index()
        {
            return await _userRepository.FindAllAsync();
        }

        [HttpPost]
        public async Task Create(User user)
        {
            await Task.Run(() => _userRepository.CreateAsync(user));
        }

        [HttpDelete]
        public async Task Delete(User user)
        {
            await Task.Run(() => _userRepository.DeleteAsync(user));
        }
    }
}
