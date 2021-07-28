using System;
using System.Collections.Generic;
using System.Text;
using Quasar.Core.Models.Validation;

namespace Quasar.Core.Models
{
    public class LoginModel : Model
    {
        [UserName]
        public string UserName { get; set; }
        [Password]
        public string Password { get; set; }
    }
}
