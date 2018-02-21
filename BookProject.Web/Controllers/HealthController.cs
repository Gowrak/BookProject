using Microsoft.AspNetCore.Mvc;

namespace BookProject.Web.Controllers
{
    [Route("health")]
    public class HealthController : Controller
    {
        // GET: /<controller>/
        public string Status()
        {
            return "up";
        }
    }
}
