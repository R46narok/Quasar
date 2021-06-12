using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quasar.Core.Native.Bluetooth;

namespace Quasar.Core.Native
{
    class Generation1Watch :  IDevice
    {
        private readonly BleConnection _connection;
        public string Name => _connection.Name;
        public Guid MacAddress => _connection.MacAddress;
        public int Generation { get; private set; } = DeviceGeneration.Generation1;

        public Generation1Watch(BleConnection connection)
        {
            _connection = connection;
           
            InitConnection();
            InitServices();
            InitCloud();
        }

        public bool IsCompatibleWith()
        {
            throw new NotImplementedException();
        }

        private void InitConnection()
        {
            //TODO: BONDING
            _connection.WaitForConnection(5000);
        }

        private void InitServices()
        {
            _connection.WaitForServiceDiscovery(5000, 6);
            _connection.WaitForCharacteristicsDiscovery(5000, 12);

            var characteristics = _connection.Characteristics;
            var gestureCharacteristic = characteristics.Find(e => e.Uuid == BleGuid.GestureCharacteristic);

            gestureCharacteristic.EnableNotifications();
            gestureCharacteristic.WhenNotificationReceived().Subscribe(observer =>
            {

            });
        }

        private void InitCloud()
        {

        }
    }
}
