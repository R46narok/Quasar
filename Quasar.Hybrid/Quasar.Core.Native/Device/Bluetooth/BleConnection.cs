using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Plugin.BluetoothLE;
// ReSharper disable ConvertClosureToMethodGroup

namespace Quasar.Core.Native.Bluetooth
{
    using IDevice = Plugin.BluetoothLE.IDevice;

    public class BleConnection
    {
        private IDevice _device;
        private readonly List<IGattCharacteristic> _gattCharacteristics;
        private readonly List<IGattService> _services;

        public ConnectionStatus Status { get; private set; }
        public List<IGattCharacteristic> Characteristics => _gattCharacteristics;
        public event EventHandler<ConnectionStatus> StatusChanged;

        public string Name => _device.Name;
        public Guid MacAddress => _device.Uuid;

        public BleConnection(IDevice device)
        {
            _gattCharacteristics = new List<IGattCharacteristic>();
            _services = new List<IGattService>();

            Status = ConnectionStatus.Disconnected;

            device.WhenConnected().Subscribe(result => OnConnected(result));
            device.WhenAnyCharacteristicDiscovered().Subscribe(result => OnAnyCharacteristicDiscovered(result));
            device.WhenStatusChanged().Subscribe(result => OnStatusChanged(result));

            device.Connect();
        }

        public bool WaitForConnection(long timeout)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (true)
            {
                if (Status == ConnectionStatus.Connected) return true;
                if (sw.ElapsedMilliseconds > timeout) return false;
            }
        }

        public bool WaitForServiceDiscovery(long timeout, int serviceCount)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (true)
            {
                if (_services.Count >= serviceCount) return true;
                if (sw.ElapsedMilliseconds > timeout) return false;
            }
        }

        public bool WaitForCharacteristicsDiscovery(long timeout, int characteristicsCount)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (true)
            {
                if (_gattCharacteristics.Count >= characteristicsCount) return true;
                if (sw.ElapsedMilliseconds > timeout) return false;
            }
        }

        private void OnConnected(IDevice device)
        {
            _device = device;
            _device.DiscoverServices().Subscribe(service =>
            {
                _services.Add(service);
                service.DiscoverCharacteristics();
            });
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
