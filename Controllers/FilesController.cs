using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        // POST api/files/upload
        [HttpPost("upload")]
        public ActionResult UploadFile(IFormFile file)
        {
            return Ok(new { testc = "jeee"});
        }
    }
}
