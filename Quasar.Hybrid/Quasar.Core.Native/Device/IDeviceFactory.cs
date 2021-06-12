using System;
using System.Collections.Generic;
using System.Text;
using Quasar.Core.Native.Bluetooth;

namespace Quasar.Core.Native
{
    public interface IDeviceFactory
    {
        IDevice CreateDevice<T>(BleConnectionManager manager, Plugin.BluetoothLE.IDevice bleDevice) where T : DeviceGeneration;
    }
}
