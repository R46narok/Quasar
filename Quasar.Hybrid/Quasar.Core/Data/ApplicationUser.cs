using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Quasar.Core.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public List<ApplicationDevice> Devices { get; set; }
    }
}
