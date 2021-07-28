using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Quasar.Core.Models.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class PasswordAttribute : Attribute, IValidationAttribute
    {
        /// <summary>
        /// To be valid, a password must have Minimum eight characters, at least one upper case English letter,
        /// one lower case English letter, one number and one special character.
        /// </summary>
        private const string Pattern = @" ^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$ ";
        private const string ErrorMessage = "Password must have minumum 8 characters...";

        public bool IsValid(object obj)
        {
            var password = (string)obj;
            Regex regex = new Regex(Pattern);
            return regex.IsMatch(password);
        }

        public void EnsureValid(object obj)
        {
            bool result = IsValid(obj);
            if (result == false) throw new ArgumentException(ErrorMessage);
        }

        public ValidationError Error => new ValidationError(this);

        public string ErrorMsg => ErrorMessage;
    }
}
