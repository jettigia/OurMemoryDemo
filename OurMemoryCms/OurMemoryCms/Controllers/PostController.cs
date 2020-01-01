using Microsoft.AspNetCore.Mvc;
using OurMemoryCms.Models;
using OurMemoryService.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace OurMemoryCms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private const string CANNOT_CREATE = "Could not create the post.";

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public ActionResult Create(PostViewModel postViewModel)
        {
            try
            {
                var newPost = _postService.Create(postViewModel);

                if (newPost != null)
                {
                    return Conflict(CANNOT_CREATE);
                }
                else
                {
                    var resourceUrl = Path.Combine(Request.Path.ToString(), Uri.EscapeUriString(newPost.Id));
                    return Created(resourceUrl, newPost);
                }
            }
            catch
            {
                return BadRequest(CANNOT_CREATE);
            }            
        }

        [HttpGet]
        public ActionResult<List<PostViewModel>> GetMyPosts()
        {
            //return Ok(Glossary.Data);
            return Conflict("Cannot create post.");
        }

        [HttpGet]
        [Route("{postId}")]
        public ActionResult<PostViewModel> Get(string postId)
        {
            string glossaryItem = "b";
            glossaryItem = null;
            if (glossaryItem == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(glossaryItem);
            }
        }
    }
}