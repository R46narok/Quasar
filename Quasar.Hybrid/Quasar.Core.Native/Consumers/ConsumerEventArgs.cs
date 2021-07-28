using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Quasar.Core.Native.Consumers
{
    public class ConsumerEventArgs<T> : EventArgs
    {
        public T Consumable { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
