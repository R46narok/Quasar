using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core.DataAccess
{
    /// <summary>
    /// This class is used to pass credentials info from the database
    /// back to the user. The user creates a hash with the received data
    /// and sends the password back to the server for security reasons.
    /// </summary>
    public class UserCredentialsInfo
    {
        public byte[] PasswordSalt { get; set; }
        public int PasswordIterations { get; set; }
    }

    /// <summary>
    /// This class is used in the REST API for user authentication.
    /// </summary>
    public class UserCredentials
    {
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
