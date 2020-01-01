using Microsoft.AspNetCore.Mvc;
using OurMemoryCms.Models;
using OurMemoryService.Interfaces;

namespace OurMemoryCms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public ActionResult Create(PostViewModel postViewModel)
        {
            return Conflict("Cannot create post.");
        }
    }
}