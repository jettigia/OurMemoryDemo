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
                var newPost = await _postService.CreateAsync(postViewModel);

                if (newPost != null)
                {
                    var resourceUrl = Path.Combine(Request.Path.ToString(), Uri.EscapeUriString(newPost.Id.ToString()));
                    return Created(resourceUrl, newPost);                    
                }
                else
                {
                    return Conflict(CANNOT_CREATE);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(CANNOT_CREATE + ex.Message);
            }            
        }

        [HttpGet]
        public async Task<ActionResult<List<PostViewModel>>> GetMyPosts()
        {
            try
            {
                var myPosts = await _postService.ReadAsync(Guid.NewGuid());
                return myPosts;
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("{postId}")]
        public async Task<ActionResult<PostViewModel>> Get(Guid postId)
        {
            try
            {
                var myPosts = await _postService.ReadAsync(postId, Guid.NewGuid());
                return myPosts;
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{postId}")]
        public async Task<ActionResult<PostViewModel>> UpdatePost(PostViewModel post)
        {
            try
            {
                var updatedPost = await _postService.UpdateAsync(post);
                return updatedPost;
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{postId}")]
        public async Task<ActionResult<bool>> DeletePost(PostViewModel post)
        {
            try
            {
                var isDeleted = await _postService.DeleteAsync(post);
                return isDeleted;
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}