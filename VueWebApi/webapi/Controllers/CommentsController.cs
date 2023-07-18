using DataAccessLayer.Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    public class CommentsController : Controller
    {
        ICommentRepository _commentRepository;

        public CommentsController(ICommentRepository commentRepository)
        {
           _commentRepository = commentRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Comment>> Index()
        {
            return await _commentRepository.FindAllAsync();
        }

        [HttpPost]
        public async Task Create(Comment comment)
        {
            await Task.Run(() => _commentRepository.CreateAsync(comment));
        }

        [HttpDelete]
        public async Task Delete(Comment comment)
        {
            await Task.Run(() => _commentRepository.DeleteAsync(comment));
        }
    }
}
