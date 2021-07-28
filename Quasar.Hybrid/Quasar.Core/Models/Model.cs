using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Quasar.Core.Models.Validation;

namespace Quasar.Core.Models
{
    public class Model
    {
        public bool IsValid(List<ValidationError> errors = null)
        {
            var type = this.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes();
                foreach (var attribute in attributes)
                {
                    if (attribute is IValidationAttribute validation)
                    {
                        bool result = validation.IsValid(property.GetValue(this));
                        errors?.Add(validation.Error);
                    }
                }
            }

            return true;
        }
    }

    public delegate void ModelSubmitted();

    public delegate Task ModelSubmittedAsync();
}
