using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Quasar.Core;
using Quasar.Core.DataAccess;

namespace Quasar.Server.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserProvider _provider;
        private readonly ILogger<UserController> _logger;
        public UserController(UserProvider provider, ILogger<UserController> logger)
        {
            _provider = provider;
            _logger = logger;
        }

        [HttpPost]
        [Route("register")]
        public ActionResult<bool> RegisterUser([FromBody] User user)
        {
            if (string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Username) ||
                user.PasswordHash == null || user.PasswordHash.Length == 0 ||
                user.PasswordSalt == null || user.PasswordSalt.Length == 0 ||
                user.PasswordIterations <= 0)
                return BadRequest();

            _logger.LogInformation($"New user registration: {user.Username} with email {user.Email}");

            return _provider.RegisterUser(user);
        }

        // TODO: Log ip of the client - sensitive info.
        [HttpPost]
        [Route("credentials_info")]
        public ActionResult<UserCredentialsInfo> CredentialsInfo([FromBody] string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return BadRequest();

            _logger.LogInformation($"UserCredentialsInfo of {username} requested by [IP]");

            return _provider.GetCredentialsInfo(username);
        }

        [HttpPost]
        [Route("authenticate")]
        public ActionResult<User> AuthenticateUser([FromBody] UserCredentials credentials)
        {
            if (string.IsNullOrWhiteSpace(credentials.Username) ||
                credentials.PasswordHash == null || credentials.PasswordHash.Length == 0)
                return BadRequest();

            var user = _provider.AuthenticateUser(credentials);

            _logger.LogInformation($"Authentication of {credentials.Username}, status: {user != null}");

            return user;
        }
    }
}
