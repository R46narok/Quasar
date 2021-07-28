using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core.Models.Validation
{
    public class ValidationError
    {
        public IValidationAttribute Sender { get; private set; }
        public string ErrorString => Sender.ErrorMsg;

        public ValidationError(IValidationAttribute sender)
        {
            Sender = sender;
        }
    }
}
