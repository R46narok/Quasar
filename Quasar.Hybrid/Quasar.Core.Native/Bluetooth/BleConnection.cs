using System;
using System.Collections.Generic;
using System.Text;
using Plugin.BluetoothLE;
// ReSharper disable ConvertClosureToMethodGroup

namespace Quasar.Core.Native.Bluetooth
{
    using IDevice = Plugin.BluetoothLE.IDevice;

    public class BleConnection
    {
        private IDevice _device;
        private List<IGattCharacteristic> _gattCharacteristics;


        public ConnectionStatus Status { get; private set; }
        public IReadOnlyCollection<IGattCharacteristic> Characteristics => _gattCharacteristics.AsReadOnly();
        public event EventHandler<ConnectionStatus> StatusChanged;

        public BleConnection(IDevice device)
        {
            _gattCharacteristics = new List<IGattCharacteristic>();
            Status = ConnectionStatus.Disconnected;

            device.WhenConnected().Subscribe(result => OnConnected(result));
            device.WhenAnyCharacteristicDiscovered().Subscribe(result => OnAnyCharacteristicDiscovered(result));
            device.WhenStatusChanged().Subscribe(result => OnStatusChanged(result));

            device.Connect();
        }

        private void OnConnected(IDevice device)
        {
            _device = device;
        }

        private void OnAnyCharacteristicDiscovered(IGattCharacteristic characteristic)
        {
            _gattCharacteristics.Add(characteristic);
        }

        private void OnStatusChanged(ConnectionStatus status)
        {
            Status = status;
            StatusChanged?.Invoke(this, status);
        }
    }
}
