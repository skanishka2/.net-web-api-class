using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    public class InfoController : ControllerBase
    {
        [HttpGet("/info")]
        public async Task<ActionResult> GetTheInfo()
        {
            return Ok("its working");
        }
    }
}
