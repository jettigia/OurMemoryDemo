using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace OurMemoryCms.Controllers
{
    [Produces("application/json")]
    [Route("api/ImageMemory")]
    public class ImageMemoryController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public ImageMemoryController(IWebHostEnvironment environment)
        {
            _environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        // TODO Make this async
        // POST: api/Image
        [HttpPost]
        public IActionResult Post(IFormFile file)
        {
            return NotFound();
        }
    }
}