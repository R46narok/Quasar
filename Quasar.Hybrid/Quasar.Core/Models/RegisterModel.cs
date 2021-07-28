using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Quasar.Core.Models.Validation;

namespace Quasar.Core.Models
{
    public class RegisterModel : Model
    {
        [UserName]
        public string UserName { get; set; }
        [Email]
        public string Email { get; set; }
        [Password]
        public string Password { get; set; }
    }
}
