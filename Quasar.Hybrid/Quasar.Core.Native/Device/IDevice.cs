using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core.Native
{
    public interface IDevice
    {
        string Name { get; }
        Guid MacAddress { get; }
        int Generation { get; }
        bool IsCompatibleWith();
    }
}
