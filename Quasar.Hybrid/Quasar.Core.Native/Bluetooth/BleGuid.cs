using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core.Native.Bluetooth
{
    public class BleGuid
    {
        public Guid DateAndTimeService { get; } = new Guid("83edc3b6-f87e-4ecb-a7d6-3245b07a6a49");
        public Guid TimeCharacteristic { get; } = new Guid( "37e3f738-3673-41e0-a5c5-67c5df23a947");
        public Guid DateCharacteristic { get; } = new Guid("76aceb1b-3b78-4a7c-82f7-a4942016df9e");
        public Guid GestureService { get; } = new Guid("1ede5126-b920-4fc4-8fd7-5f50eb845bc4");
        public Guid GestureCharacteristic { get; } = new Guid("aec46cce-13d3-4223-8540-181f32f8fcea");

        public List<Guid> AsList()
        {
            return new List<Guid>
            {
                DateAndTimeService,
                TimeCharacteristic,
                DateCharacteristic,

                GestureService,
                GestureCharacteristic
            };
        }
    }
}
