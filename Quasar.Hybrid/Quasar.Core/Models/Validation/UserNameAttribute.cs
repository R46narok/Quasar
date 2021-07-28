using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Quasar.Core.Models.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class UserNameAttribute : Attribute, IValidationAttribute
    {
        /// <summary>
        /// To be valid, a username must start with a letter,
        /// and is allowed to have letters and numbers. The length between 6 to 12 characters.
        /// </summary>
        private const string Pattern = @"^[a-zA-Z][a-zA-Z0-9]{5,11}$";
        private const string ErrorMessage = "Username must be between 6 to 12 characters and start with a letter!";

        public bool IsValid(object obj)
        {
            var username = (string) obj;
            Regex regex = new Regex(Pattern);
            return regex.IsMatch(username);
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
