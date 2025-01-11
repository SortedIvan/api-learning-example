using api_learning_project.Service;
using Microsoft.AspNetCore.Mvc;

namespace api_learning_project.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService userService;

        private readonly UserService createAccountService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("createaccount")]
        public IActionResult CreateAccount(string username, string password, string email)
        {
            bool result = userService.CreateAccount(username, password, email);

            if (result)
            {
                return Ok("Account successfully created");
            }

            return BadRequest("Failed to create account. Please check your input or try again.");
        }
    }
}
