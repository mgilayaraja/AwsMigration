using AwsMigration.Contracts.IServices;
using Microsoft.AspNetCore.Mvc;

namespace AwsMigration.Controllers
{
    [Route("user")]
    public class UserController : BaseController
    {
        #region Declaration
        private readonly IUserService _userService;

        #endregion

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #region Sign In
        /// <summary>
        /// Sign In
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        [Route("signin")]
        [HttpPost]
        public async Task<IActionResult> SignIn(string emailAddress)
        {
            var loginResponse = await _userService.GetUserByEmail(emailAddress);
            return Ok(loginResponse);
        }
        #endregion
    }
}
