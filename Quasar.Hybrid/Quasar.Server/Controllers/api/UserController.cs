using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Quasar.Core;
using Quasar.Core.Models;
using Quasar.Core.Data;
using Quasar.Hybrid.Shared.Components;
using Quasar.Hybrid.Shared.Storage;

namespace Quasar.Server.Controllers.api
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(ILogger<UserController> logger, 
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        { 
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("authenticate")]
        public async Task<ActionResult<ApplicationUser>> AuthenticateAsync([FromBody] LoginModel model)
        {
            if (model.IsValid())
            {
                var user = await _userManager.FindByNameAsync(model.UserName);

                if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    return Ok(user);
                }

                return BadRequest();
            }

            return UnprocessableEntity();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("authenticate_hash")]
        public async Task<ActionResult<bool>> AuthenticateByHashAsync([FromBody] ApplicationUser model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null && user.PasswordHash == model.PasswordHash)
            {
                return Ok(true);
            }

            return Ok(false);
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<ApplicationUser>> RegisterAsync([FromBody] RegisterModel model)
        {
            if (model.IsValid())
            {
                var user = new ApplicationUser
                {
                    UserName = model.UserName,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result == IdentityResult.Success)
                {
                    await _userManager.AddClaimAsync(user, ApplicationClaimTypes.UserClaim);
                    return Ok();
                }
            }

            return UnprocessableEntity();
        }
    }
}
