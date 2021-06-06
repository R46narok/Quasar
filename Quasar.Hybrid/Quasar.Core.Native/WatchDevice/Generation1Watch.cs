using System;
using System.Collections.Generic;
using System.Text;
using Quasar.Core.Native.Bluetooth;

namespace Quasar.Core.Native
{
    class Generation1Watch :  IDevice
    {
        private BleConnection _connection;
        public int Generation { get; private set; } = DeviceGeneration.Generation1;

        public Generation1Watch(BleConnection connection)
        {
            _connection = connection;
        }

        public bool IsCompatibleWith()
        {
            throw new NotImplementedException();
        }

    }
}
