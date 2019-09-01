using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using OurMemory.Data.DataControllers;

namespace OurMemory.Controllers
{
    public class MemoryController : Controller
    {
        private readonly MemoryDataController _memoryDataController;
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;

        public MemoryController(MemoryDataController memoryDataController,
                          IFileProvider fileprovider, IHostingEnvironment env)
        {
            _memoryDataController = memoryDataController;
            fileProvider = fileprovider;
            hostingEnvironment = env;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // https://www.codeproject.com/Tips/4051593/How-to-Upload-Images-on-an-ASP-NET-Core-2-2-MVC-We
    }
}
