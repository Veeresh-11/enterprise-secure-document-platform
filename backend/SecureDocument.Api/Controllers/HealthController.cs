using Microsoft.AspNetCore.Mvc;

namespace SecureDocument.Api.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                status = "Healthy",
                service = "SecureDocument.Api",
                timestamp = DateTime.UtcNow
            });
        }
    }
}
