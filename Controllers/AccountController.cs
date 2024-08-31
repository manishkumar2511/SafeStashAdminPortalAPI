using Microsoft.AspNetCore.Mvc;
using SafeStashAdminPortalAPI.DTO;
using SafeStashAdminPortalAPI.DTO.Response;


namespace SafeStashAdminPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
       

        [HttpPost("Login")]
        public async Task<ActionResult<AccountResponse>> Login (LoginDto model)
        {
            try
            {
                
                return Unauthorized("Invalid username or password. Please check your credentials and try again");
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("RefreshToken")]
        public async Task<IActionResult> RefreshToken(string refreshToken)
        {
            try
            {


               
                return Unauthorized("Invalid Refresh Token");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during token refresh: {ex}");
                return BadRequest(ex.Message);
            }
        }
    }
}
