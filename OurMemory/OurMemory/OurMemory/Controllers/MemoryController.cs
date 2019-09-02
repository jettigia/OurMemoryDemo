using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace OurMemoryApi.Controllers
{
    public class MemoryController : Controller
    {
        private readonly IFileProvider _fileProvider;
        private readonly IHostingEnvironment _hostingEnvironment;

        public MemoryController(IFileProvider fileprovider, IHostingEnvironment env)
        {
            _fileProvider = fileprovider;
            _hostingEnvironment = env;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // https://www.codeproject.com/Tips/4051593/How-to-Upload-Images-on-an-ASP-NET-Core-2-2-MVC-We
    }
}
