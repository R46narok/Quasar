using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core
{
    public class UserCredentialsInfo
    {
        public byte[] PasswordSalt { get; set; }
        public int PasswordIterations { get; set; }
    }

    public class UserCredentials
    {
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
