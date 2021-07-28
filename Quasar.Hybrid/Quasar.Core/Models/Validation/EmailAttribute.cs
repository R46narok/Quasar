using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Quasar.Core.Models.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class EmailAttribute : Attribute, IValidationAttribute
    {
        private const string Pattern = @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+";
        private const string ErrorMessage = "Email is not valid!";

        public bool IsValid(object obj)
        {
            var email = (string)obj;
            Regex regex = new Regex(Pattern);
            return regex.IsMatch(email);
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
