using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OurMemory.Models;
using OurMemoryService.Interfaces;
using OurMemoryService.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace OurMemoryCms.Controllers
{
    [Produces("application/json")]
    [Route("api/ImageMemory")]
    public class MemoryController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IMemoryService _memoryService;
        private const string CANNOT_CREATE = "Could not create the post. ";

        public MemoryController(IWebHostEnvironment environment, IMemoryService memoryService)
        {
            _environment = environment ?? throw new ArgumentNullException(nameof(environment));
            _memoryService = memoryService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateTextModel(MemoryInputModel textMemoryViewModel)
        {
            try
            {
                var userId = HttpContext.User.Identity.Name;
                var newPost = await _memoryService.CreateAsync(userId, textMemoryViewModel);

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
        public async Task<ActionResult<List<MemoryViewModel>>> GetMyPosts()
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
        public async Task<ActionResult<MemoryViewModel>> Get(Guid postId)
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
        public async Task<ActionResult<MemoryViewModel>> UpdatePost(MemoryViewModel post)
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
        public async Task<ActionResult<bool>> DeletePost(MemoryViewModel post)
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

        [HttpPost("UploadFile")]
        public async Task<string> UploadFile([FromForm] IFormFile file)
        {
            string fName = file.FileName;
            string path = Path.Combine(_environment.ContentRootPath, "Images/" + file.FileName);

            var upload = new MemoryInputModel()
            {
                UserId = HttpContext.User.Identity.Name,
            };

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await stream.ReadAsync(upload.FileContent);
            }

            var userId = HttpContext.User.Identity.Name;
            var memoryViewModel = await _memoryService.CreateAsync(userId, upload);
            return file.FileName;
        }
    }
}