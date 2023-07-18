using DataAccessLayer.Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Post>> Index()
        {
            return await _postRepository.FindAllAsync();
        }

        [HttpPost]
        public async Task Create(Post post)
        {
            await Task.Run(() => _postRepository.CreateAsync(post));
        }

        [HttpDelete]
        public async Task Delete(Post post)
        {
            await Task.Run(() => _postRepository.DeleteAsync(post));
        }
    }
}
