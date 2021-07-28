using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core.Models.Validation
{
    public interface IValidationAttribute
    {
        bool IsValid(object obj);
        void EnsureValid(object obj);
        ValidationError Error { get; }
        string ErrorMsg { get; }
    }
}
