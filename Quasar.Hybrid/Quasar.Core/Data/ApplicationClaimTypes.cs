using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Quasar.Core.Data
{
    public class ApplicationClaimTypes
    {
        public static List<string> UserClaims { get; set; } = new List<string>
        {
            "Admin", "Subscriber","User","Disabled"
        };

        public static Claim UserClaim => new Claim("User", "User");
    }
}
