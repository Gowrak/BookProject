using System;
using Microsoft.AspNetCore.Mvc;
namespace BookProject.Web.Controllers
{
    [Route("bookinfo")]
    public class BookInfoController : Controller
    {
        [HttpGet]
        public IActionResult Info()
        {
            return Ok(Json("UP"));
        }
    }
}
