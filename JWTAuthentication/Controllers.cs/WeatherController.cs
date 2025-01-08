using JWTAuthentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        public WeatherController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> WeatherNow ()
        {
            try
            {
                return Ok(new {Message = "Sunny Day"});
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
