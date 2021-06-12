#ifndef QUASAR_BLE_UUIDS_H
#define QUASAR_BLE_UUIDS_H

/*



2a72bc75-31e3-4cc6-b105-247299429b7b
e24d574f-f563-4dea-9c99-fec555410efb
0a9f9a66-528b-46f7-859d-9c2ce124b20d
*/

namespace Quasar
{
    struct Uuid
    {
        static constexpr const char* DeviceInfoService = "4496321d-7fcc-4ad6-8e50-0327128050f5";
        static constexpr const char* DeviceGenerationCharacteristic = "46667336-6aba-49de-b873-474129c7214b";
        static constexpr const char* DeviceTypeCharacteristic = "2a72bc75-31e3-4cc6-b105-247299429b7b";

        static constexpr const char* DateAndTimeService = "83edc3b6-f87e-4ecb-a7d6-3245b07a6a49";
        static constexpr const char* TimeCharacteristic = "37e3f738-3673-41e0-a5c5-67c5df23a947";
        static constexpr const char* DateCharacteristic = "76aceb1b-3b78-4a7c-82f7-a4942016df9e";

        static constexpr const char* GestureService = "1ede5126-b920-4fc4-8fd7-5f50eb845bc4";
        static constexpr const char* GestureCharacteristic = "aec46cce-13d3-4223-8540-181f32f8fcea";
    };
}

#endif