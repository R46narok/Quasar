using System;
using System.Collections.Generic;
using System.Text;
using Plugin.BluetoothLE;

namespace Quasar.Core.Bluetooth
{
    public class BleConnectionManager
    {
        private readonly IAdapter _adapter;

        public BleConnectionManager()
        {
            _adapter = CrossBleAdapter.Current;
            
            Connect();
        }

        private void Connect()
        {
            _adapter.ScanForUniqueDevices().Subscribe(device =>
            {
            });
        }
    }
}
