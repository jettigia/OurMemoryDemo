using Microsoft.AspNetCore.Mvc;
using OurMemory.Models;
using OurMemoryService.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace OurMemoryCms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private const string CANNOT_CREATE = "Could not create the post. ";

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public async Task<ActionResult> Create(PostViewModel postViewModel)
        {
            try
            {
                var newPost = await _postService.Create(postViewModel);

                if (newPost != null)
                {
                    return Conflict(CANNOT_CREATE);
                }
                else
                {
                    var resourceUrl = Path.Combine(Request.Path.ToString(), Uri.EscapeUriString(newPost.Id.ToString()));
                    return Created(resourceUrl, newPost);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(CANNOT_CREATE + ex.Message);
            }            
        }

        [HttpGet]
        public ActionResult<List<PostViewModel>> GetMyPosts()
        {
            return Conflict("Cannot create post.");
        }

        [HttpGet]
        [Route("{postId}")]
        public ActionResult<PostViewModel> Get(string postId)
        {
            string glossaryItem = "b";
            glossaryItem = null;
            if (string.IsNullOrWhiteSpace(postId))
            {
                return NotFound();
            }
            else
            {
                return Ok(glossaryItem);
            }
        }

        // Still need update and delete.
    }
}