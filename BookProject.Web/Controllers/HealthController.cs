using Microsoft.AspNetCore.Mvc;

namespace BookProject.Web.Controllers
{
    [Route("health")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Status()
        {
            return Ok(Json("UP")); 
        }
    }
}
