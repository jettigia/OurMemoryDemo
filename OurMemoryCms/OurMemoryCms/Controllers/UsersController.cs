using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OurMemory.Configuration;
using OurMemory.Models;
using OurMemoryService.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace OurMemoryCms.Controllers
{
    [Authorize]
    [EnableCors(Startup.VUE_CORS_POLICY)]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private const string USER_ID_CLAIM = "UserIdClaim";

        public UsersController(
            IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]AuthenticateInputModel model)
        {
            var user = await _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, model.Username)
            };

            var userIdentity = new ClaimsIdentity(claims, "login");

            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);

            // return basic user info and authentication token
            return Ok(new {
                user.Username                
        }

        [EnableCors(Startup.VUE_CORS_POLICY)]
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterInputModel model)
        {
            try
            {
                //create user
                var newUser = await _userService.Create(model, model.Password);
                return Ok(newUser);
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        // TODO: This needs Authorize and get current user with token
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody]UpdateViewModel model)
        {
            try
            {
                // update user 
                _userService.Update(model, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogoutAsync(Guid id, [FromBody]UserViewModel model)
        {
            await HttpContext.SignOutAsync();
            return Ok();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("version")]
        public ActionResult GetVersion()
        {
            return Ok("Version: 1.0.0.8");
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("version")]
        public ActionResult GetVersionPost()
        {
            return Ok("Post Version: 1.0.0.8");
        }
    }
}
