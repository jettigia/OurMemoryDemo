using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OurMemory.Models;
using OurMemoryService.Services;
using System;
using System.IO;
using System.Threading.Tasks;

namespace OurMemoryCms.Controllers
{
    [Produces("application/json")]
    [Route("api/ImageMemory")]
    public class MemoryController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly MemoryService _memoryService;

        public MemoryController(IWebHostEnvironment environment, MemoryService memoryService)
        {
            _environment = environment ?? throw new ArgumentNullException(nameof(environment));
            _memoryService = memoryService;
        }

        [HttpPost("UploadFile")]
        public async Task<string> UploadFile([FromForm] IFormFile file)
        {
            string fName = file.FileName;
            string path = Path.Combine(_environment.ContentRootPath, "Images/" + file.FileName);

            var upload = new ImageMemoryInputModel()
            {
                UserId = HttpContext.User.Identity.Name,
            };

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await stream.ReadAsync(upload.FileContent);
            }

            var userId = HttpContext.User.Identity.Name;
            var memoryViewModel = await _memoryService.CreateImageMemoryAsync(userId, upload);
            return file.FileName;
        }
    }
}