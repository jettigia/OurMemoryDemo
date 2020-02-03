using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OurMemory.Models;
using OurMemoryService.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OurMemoryCms.Controllers
{
    [Authorize]
    [EnableCors(Startup.VUE_CORS_POLICY)]
    [Route("api/[controller]")]
    [ApiController]
    
    public class TextMemoryController : ControllerBase
    {
        private readonly IMemoryService _memoryService;
        private const string CANNOT_CREATE = "Could not create the post. ";

        public TextMemoryController(IMemoryService memoryService)
        {
            _memoryService = memoryService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> CreateTextModel(TextMemoryInputModel textMemoryViewModel)
        {
            try
            {
                var userId = HttpContext.User.Identity.Name;
                var newPost = await _memoryService.CreateTextMemoryAsync(userId, textMemoryViewModel);

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
        public async Task<ActionResult<List<TextMemoryViewModel>>> GetMyPosts()
        {
            try
            {
                var myPosts = await _memoryService.ReadAsync(Guid.NewGuid());
                return myPosts;
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("{postId}")]
        public async Task<ActionResult<TextMemoryViewModel>> Get(Guid postId)
        {
            try
            {
                var myPosts = await _memoryService.ReadAsync(postId, Guid.NewGuid());
                return myPosts;
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{postId}")]
        public async Task<ActionResult<TextMemoryViewModel>> UpdatePost(TextMemoryViewModel post)
        {
            try
            {
                var updatedPost = await _memoryService.UpdateAsync(post);
                return updatedPost;
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{postId}")]
        public async Task<ActionResult<bool>> DeletePost(TextMemoryViewModel post)
        {
            try
            {
                var isDeleted = await _memoryService.DeleteAsync(post);
                return isDeleted;
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
