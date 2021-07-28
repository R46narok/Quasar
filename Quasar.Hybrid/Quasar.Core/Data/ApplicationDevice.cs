using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quasar.Core.Device;

namespace Quasar.Core.Data
{
    public class ApplicationDevice : IDevice
    {
        public int ID { get; set; }
        public ApplicationUser User { get; set; }
        public string Name { get; set; }
        public Guid MacAddress { get; set; }
        public DeviceGeneration Generation { get; set; }
    }
}