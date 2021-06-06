using System;
using System.Collections.Generic;
using System.Text;
using Plugin.BluetoothLE;

namespace Quasar.Core.Native.Bluetooth
{
    using IDevice = Plugin.BluetoothLE.IDevice;

    public class BleConnectionManager
    {
        private readonly IAdapter _bleAdapter;
        private List<BleConnection> _connections;

        public event EventHandler<IDevice> CompatibleDeviceFound;
        public IReadOnlyCollection<BleConnection> Connections => _connections;


        public BleConnectionManager()
        {
            _bleAdapter = CrossBleAdapter.Current;
            _connections = new List<BleConnection>();
        }

        public void StartScan()
        {
            if (_bleAdapter.IsScanning == false)
            {
                ScanConfig config = new ScanConfig
                {
                    ScanType = BleScanType.LowLatency,
                };

                _bleAdapter.ScanForUniqueDevices(config).Subscribe(device =>
                {
                    CompatibleDeviceFound?.Invoke(this, device);
                });
            }
        }

        public void StopScan()
        {
            if (_bleAdapter.IsScanning)
                _bleAdapter.StopScan();
        }

        public void AddConnection(BleConnection connection)
        {
            _connections.Add(connection);
            connection.StatusChanged += OnConnectionStatusChanged;
        }

        private void OnConnectionStatusChanged(object sender, ConnectionStatus status)
        {
            var connection = (BleConnection) sender;

            if (status == ConnectionStatus.Disconnecting)
            {
                _connections.Remove(connection);
            }
        }
    }
}
