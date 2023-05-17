using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Commander.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FilesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        

        // POST api/files/upload
        [HttpPost("upload")]
        public ActionResult UploadFile(IFormFile file)
        {
            var wwwPath = _webHostEnvironment.WebRootPath;
            var path = Path.Combine(wwwPath, "Uploads");
            var fileName = Path.GetFileName(file.FileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return Ok(new { testc = "jeee"});
        }
    }
}
