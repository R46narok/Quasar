using System;
using System.Collections.Generic;
using System.Text;
using Quasar.Core.Device;

namespace Quasar.Core
{
    public interface IDevice
    {
        string Name { get; }
        Guid MacAddress { get; }
        DeviceGeneration Generation { get; }
    }
}
