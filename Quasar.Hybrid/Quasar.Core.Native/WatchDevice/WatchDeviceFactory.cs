using System;
using System.Collections.Generic;
using System.Text;
using Quasar.Core.Native.Bluetooth;

namespace Quasar.Core.Native
{
    public class WatchDeviceFactory : IDeviceFactory
    {
        public IDevice CreateDevice<T>(BleConnectionManager manager, Plugin.BluetoothLE.IDevice bleDevice) where T : DeviceGeneration
        {
            var type = typeof(T);
            if (type == typeof(DeviceGeneration1)) { return CreateGeneration1Device(manager, bleDevice); }
            if (type == typeof(DeviceGeneration2)) { return CreateGeneration2Device(manager, bleDevice); }

            return null;
        }

        private IDevice CreateGeneration1Device(BleConnectionManager manager, Plugin.BluetoothLE.IDevice bleDevice)
        {
            var connection = new BleConnection(bleDevice);
            manager.AddConnection(connection);

            return new Generation1Watch(connection);
        }

        private IDevice CreateGeneration2Device(BleConnectionManager manager, Plugin.BluetoothLE.IDevice bleDevice)
        {
            return null;
        }
    }
}
